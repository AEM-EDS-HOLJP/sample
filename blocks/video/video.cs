.video {
  text-align: center;
  max-width: 900px;
  margin: 24px auto;
}

.video[data-embed-loaded='false']:not(.placeholder) {
  /* reserve an approximate space to avoid extensive layout shifts */
  aspect-ratio: 16 / 9;
}

.video > div {
  display: flex;
  justify-content: center;
}

.video video {
  max-width: 100%;
}

.video .video-placeholder {
  width: 100%;
  aspect-ratio: 16 / 9;
  position: relative;
}

.video .video-placeholder > * {
  display: flex;
  align-items: center;
  justify-content: center;
  position: absolute;
  inset: 0;
}

.video[data-embed-loaded='true'] .video-placeholder,
.video[data-embed-loaded='false'] .video-placeholder + * {
  visibility: hidden;
  height: 0;
  width: 0;
}

.video .video-placeholder picture img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}

.video .video-placeholder-play button {
  position: relative;
  display: block;
  width: 44px;
  height: 44px;
  border-radius: 50%;
  outline: 2px solid;
  padding: 0;
}

.video .video-placeholder-play button::before {
  content: '';
  display: block;
  box-sizing: border-box;
  position: absolute;
  width: 0;
  height: 24px;
  border-top: 12px solid transparent;
  border-bottom: 12px solid transparent;
  border-left: 18px solid;
  top: 50%;
  left: calc(50% + 2px);
  transform: translate(-50%, -50%);
}