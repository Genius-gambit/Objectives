from ultralytics import YOLO
# import gi

# gi.require_version('Gst', '1.0')
# from gi.repository import Gst, GObject

# GObject.threads_init()
# Gst.init(None)

# pipeline_description = "rtspsrc location=rtsp://10.10.30.99:554/media/video1 latency=10 ! rtph264depay ! h264parse ! omxh264dec ! nvoverlaysink overlay-x=400 overlay-y=0 overlay-w=1280 overlay-h=720 overlay=2"
# pipeline = Gst.parse_launch(pipeline_description)

# pipeline.set_state(Gst.State.PLAYING)
# model = YOLO("yolov8n.pt")
# results = model(source=pipeline,save=True,save_txt=False,conf=0.4,project='detection_results')

# mainLoop = GObject.MainLoop()
#try:
    # mainLoop.run()
# except  KeyboardInterrupt:
    # pipeline.set_state(Gst.State.NULL)
