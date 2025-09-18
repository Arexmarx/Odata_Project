declare module "react-plotly.js" {
  import * as React from "react";

  interface PlotParams {
    data: Partial<Plotly.Data>[];
    layout?: Partial<Plotly.Layout>;
    frames?: Partial<Plotly.Frame>[];
    config?: Partial<Plotly.Config>;
    style?: React.CSSProperties;
    className?: string;
    useResizeHandler?: boolean;
    onInitialized?: (figure: any, graphDiv: any) => void;
    onUpdate?: (figure: any, graphDiv: any) => void;
  }

  export default class Plot extends React.Component<PlotParams> {}
}
