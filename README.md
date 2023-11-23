## Objectives  :notebook_with_decorative_cover:(11 May 2023~)

## Work Log

Jira resolve procedure:
1. Go to child -> Select for Dev/Fixing -> In Progress -> Workflow -> Resolved.
2. Go to parent -> In Progress -> Resolve.

Creative README.MD:
https://github.com/coderjojo/creative-profile-readme


Steps:

cd ~/ultralytics

sudo docker pull nvcr.io/nvidia/l4t-pytorch:r35.2.1-pth2.0-py3

sudo docker run -it --rm --runtime nvidia --network host nvcr.io/nvidia/l4t-pytorch:r35.2.1-pth2.0-py3

Steps:

cd ~/ultralytics

git clone https://github.com/ultralytics/ultralytics.git && pip install ultralytics && pip install protobuf

cd ultralytics/

sudo apt upgrade -y && pip install -r requirements.txt && pip install "opencv-python-headless<4.3" && yolo predict model=yolov8n.pt source='rtsp://10.10.10.7:554/media/video1' show=True && sudo apt upgrade -y

sudo apt-get install ubuntu-restricted-extras

https://github.com/SkalskiP/yolov8-live/blob/master/

gst-launch-1.0 rtspsrc location=rtsp://10.10.30.99:554/media/video1 latency=10 ! rtph264depay ! h264parse ! omxh264dec ! nvoverlaysink overlay-x=400 overlay-y=0 overlay-w=1280 overlay-h=720 overlay=2


    /********Code********/
    import gi

    gi.require_version('Gst', '1.0')
    from gi.repository import Gst, GObject

    GObject.threads_init()
    Gst.init(None)

    pipeline_description = "rtspsrc location=rtsp://10.10.30.99:554/media/video1 latency=10 ! rtph264depay ! h264parse ! omxh264dec ! nvoverlaysink overlay-x=400 overlay-y=0 overlay-w=1280 overlay-h=720 overlay=2"
    pipeline = Gst.parse_launch(pipeline_description)

    pipeline.set_state(Gst.State.PLAYING)

    mainLoop = GObject.MainLoop()
    try:
        mainLoop.run()
    except  KeyboardInterrupt:
        pipeline.set_state(Gst.State.NULL)
