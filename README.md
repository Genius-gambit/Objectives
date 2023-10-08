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

git clone https://github.com/ultralytics/ultralytics.git

pip install ultralytics

pip install protobuf

cd ultralytics/

pip install -r requirements.txt

pip install "opencv-python-headless<4.3"

yolo predict model=yolov8n.pt source='https://ultralytics.com/images/bus.jpg'

sudo apt upgrade -y

sudo apt-get install ubuntu-restricted-extras
