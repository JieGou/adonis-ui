using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace AdonisUI.Extensions
{
  /// <summary>
  /// 进度条扩展
  /// </summary>
  public class ProgressBarExtension
  {
    /// <summary>
    /// 获取内容
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static object GetContent(DependencyObject obj)
    {
      return (object)obj.GetValue(ContentProperty);
    }

    /// <summary>
    /// 设置内容
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="value"></param>
    public static void SetContent(DependencyObject obj, object value)
    {
      obj.SetValue(ContentProperty, value);
    }

    /// <summary>
    /// 获取模板
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static DataTemplate GetContentTemplate(DependencyObject obj)
    {
      return (DataTemplate)obj.GetValue(ContentTemplateProperty);
    }

    /// <summary>
    /// 设置模板
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="value"></param>
    public static void SetContentTemplate(DependencyObject obj, DataTemplate value)
    {
      obj.SetValue(ContentTemplateProperty, value);
    }

    /// <summary>
    /// 获取背景
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static Brush GetForeground(DependencyObject obj)
    {
      return (Brush)obj.GetValue(ForegroundProperty);
    }

    /// <summary>
    /// 设置背景
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="value"></param>
    public static void SetForeground(DependencyObject obj, Brush value)
    {
      obj.SetValue(ForegroundProperty, value);
    }

    /// <summary>
    /// 获取进度条动画背景
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static Brush GetProgressAnimationForeground(DependencyObject obj)
    {
      return (Brush)obj.GetValue(ProgressAnimationForegroundProperty);
    }

    /// <summary>
    /// 设置进度条动画背景
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="value"></param>
    public static void SetProgressAnimationForeground(DependencyObject obj, Brush value)
    {
      obj.SetValue(ProgressAnimationForegroundProperty, value);
    }

    /// <summary>
    /// 获取进度条动画可用状态
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static bool GetIsProgressAnimationEnabled(DependencyObject obj)
    {
      return (bool)obj.GetValue(IsProgressAnimationEnabledProperty);
    }

    /// <summary>
    /// 设置进度条动画可用状态
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="value"></param>
    public static void SetIsProgressAnimationEnabled(DependencyObject obj, bool value)
    {
      obj.SetValue(IsProgressAnimationEnabledProperty, value);
    }

    /// <summary>
    /// 内容
    /// </summary>
    public static readonly DependencyProperty ContentProperty
      = DependencyProperty.RegisterAttached("Content",
                                            typeof(object),
                                            typeof(ProgressBarExtension),
                                            new PropertyMetadata(null));

    /// <summary>
    /// 模板
    /// </summary>
    public static readonly DependencyProperty ContentTemplateProperty
      = DependencyProperty.RegisterAttached("ContentTemplate",
                                            typeof(DataTemplate),
                                            typeof(ProgressBarExtension),
                                            new PropertyMetadata(null));

    /// <summary>
    /// 进度条动画背景颜色
    /// </summary>
    public static readonly DependencyProperty ProgressAnimationForegroundProperty
      = DependencyProperty.RegisterAttached("ProgressAnimationForeground",
                                            typeof(Brush),
                                            typeof(ProgressBarExtension),
                                            new PropertyMetadata(System.Windows.Media.Brushes.Black));

    /// <summary>
    /// 前景
    /// </summary>
    public static readonly DependencyProperty ForegroundProperty
      = DependencyProperty.RegisterAttached("Foreground",
                                            typeof(Brush),
                                            typeof(ProgressBarExtension),
                                            new PropertyMetadata(System.Windows.Media.Brushes.Black));

    /// <summary>
    /// 进度条动画是否可用
    /// </summary>
    public static readonly DependencyProperty IsProgressAnimationEnabledProperty
      = DependencyProperty.RegisterAttached("IsProgressAnimationEnabled",
                                            typeof(bool),
                                            typeof(ProgressBarExtension),
                                            new PropertyMetadata(false));
  }
}