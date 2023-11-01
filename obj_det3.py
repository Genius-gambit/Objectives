import gi
gi.require_version('Gst', '1.0')
from gi.repository import Gst

def main():
    # Initialize GStreamer
    Gst.init(None)

    # Create a GStreamer pipeline
    pipeline_str = "playbin uri=rtsp://admin:Admin123.@10.10.30.100:554/Streaming/Channels/101 uridecodebin0::source::latency=1"
    pipeline = Gst.parse_launch(pipeline_str)

    # Start the pipeline
    pipeline.set_state(Gst.State.PLAYING)

    try:
        # Run the pipeline
        bus = pipeline.get_bus()
        msg = bus.timed_pop_filtered(Gst.CLOCK_TIME_NONE, Gst.MessageType.ERROR | Gst.MessageType.EOS)
        if msg:
            if msg.type == Gst.MessageType.ERROR:
                err, debug = msg.parse_error()
                print(f"Error received from element {msg.src.get_name()}: {err} ({debug})")
        else:
            print("End of stream reached.")
    except KeyboardInterrupt:
        pass
    finally:
        # Stop and cleanup the pipeline
        pipeline.set_state(Gst.State.NULL)

if __name__ == '__main__':
    main()

