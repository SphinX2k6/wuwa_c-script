using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200097E RID: 2430
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CurveLinearColor")]
	[UnrealStructLayout(672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 672)]
	public class UCurveLinearColor : UCurveBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008972 RID: 35186 RVA: 0x000C4E24 File Offset: 0x000C3024
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCurveLinearColor._ClassPtr;
		}

		// Token: 0x06008973 RID: 35187 RVA: 0x000C4E30 File Offset: 0x000C3030
		public UCurveLinearColor() : this(BuiltinUtils.AllocNativeUObject(UCurveLinearColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008974 RID: 35188 RVA: 0x000C4E58 File Offset: 0x000C3058
		public UCurveLinearColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCurveLinearColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x06008975 RID: 35189 RVA: 0x000C4E8C File Offset: 0x000C308C
		// (set) Token: 0x06008976 RID: 35190 RVA: 0x000C4EC6 File Offset: 0x000C30C6
		public TFixedArray<FRichCurve> FloatCurves
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FRichCurve> result;
				if ((result = this._FloatCurves) == null)
				{
					result = (this._FloatCurves = new TFixedArray<FRichCurve>(base.NativePtr + (IntPtr)UCurveLinearColor.__PropertyOffset_FloatCurves, 4, this));
				}
				return result;
			}
			set
			{
				this.FloatCurves.CopyAssign(value);
			}
		}

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x06008977 RID: 35191 RVA: 0x000C4ED4 File Offset: 0x000C30D4
		// (set) Token: 0x06008978 RID: 35192 RVA: 0x000C4EE4 File Offset: 0x000C30E4
		public unsafe float AdjustHue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCurveLinearColor.__PropertyOffset_AdjustHue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCurveLinearColor.__PropertyOffset_AdjustHue) = value;
			}
		}

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x06008979 RID: 35193 RVA: 0x000C4EF5 File Offset: 0x000C30F5
		// (set) Token: 0x0600897A RID: 35194 RVA: 0x000C4F05 File Offset: 0x000C3105
		public unsafe float AdjustSaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCurveLinearColor.__PropertyOffset_AdjustSaturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCurveLinearColor.__PropertyOffset_AdjustSaturation) = value;
			}
		}

		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x0600897B RID: 35195 RVA: 0x000C4F16 File Offset: 0x000C3116
		// (set) Token: 0x0600897C RID: 35196 RVA: 0x000C4F26 File Offset: 0x000C3126
		public unsafe float AdjustBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCurveLinearColor.__PropertyOffset_AdjustBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCurveLinearColor.__PropertyOffset_AdjustBrightness) = value;
			}
		}

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x0600897D RID: 35197 RVA: 0x000C4F37 File Offset: 0x000C3137
		// (set) Token: 0x0600897E RID: 35198 RVA: 0x000C4F47 File Offset: 0x000C3147
		public unsafe float AdjustBrightnessCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCurveLinearColor.__PropertyOffset_AdjustBrightnessCurve);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCurveLinearColor.__PropertyOffset_AdjustBrightnessCurve) = value;
			}
		}

		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x0600897F RID: 35199 RVA: 0x000C4F58 File Offset: 0x000C3158
		// (set) Token: 0x06008980 RID: 35200 RVA: 0x000C4F68 File Offset: 0x000C3168
		public unsafe float AdjustVibrance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCurveLinearColor.__PropertyOffset_AdjustVibrance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCurveLinearColor.__PropertyOffset_AdjustVibrance) = value;
			}
		}

		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x06008981 RID: 35201 RVA: 0x000C4F79 File Offset: 0x000C3179
		// (set) Token: 0x06008982 RID: 35202 RVA: 0x000C4F89 File Offset: 0x000C3189
		public unsafe float AdjustMinAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCurveLinearColor.__PropertyOffset_AdjustMinAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCurveLinearColor.__PropertyOffset_AdjustMinAlpha) = value;
			}
		}

		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x06008983 RID: 35203 RVA: 0x000C4F9A File Offset: 0x000C319A
		// (set) Token: 0x06008984 RID: 35204 RVA: 0x000C4FAA File Offset: 0x000C31AA
		public unsafe float AdjustMaxAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCurveLinearColor.__PropertyOffset_AdjustMaxAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCurveLinearColor.__PropertyOffset_AdjustMaxAlpha) = value;
			}
		}

		// Token: 0x06008985 RID: 35205 RVA: 0x000C4FBB File Offset: 0x000C31BB
		public FLinearColor GetLinearColorValue(float InTime)
		{
			return UCurveLinearColor.__GetLinearColorValue_Internal(base.NativePtr, InTime);
		}

		// Token: 0x06008986 RID: 35206 RVA: 0x000C4FC9 File Offset: 0x000C31C9
		public FLinearColor GetClampedLinearColorValue(float InTime)
		{
			return UCurveLinearColor.__GetClampedLinearColorValue_Internal(base.NativePtr, InTime);
		}

		// Token: 0x06008987 RID: 35207
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetLinearColorValue_Internal(IntPtr @this, float InTime);

		// Token: 0x06008988 RID: 35208
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetClampedLinearColorValue_Internal(IntPtr @this, float InTime);

		// Token: 0x06008989 RID: 35209 RVA: 0x000C4FD7 File Offset: 0x000C31D7
		static UCurveLinearColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CurveLinearColor");
		}

		// Token: 0x0600898A RID: 35210 RVA: 0x000C4FE5 File Offset: 0x000C31E5
		protected UCurveLinearColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004147 RID: 16711
		public new const string __ObjectPath = "/Script/Engine.CurveLinearColor";

		// Token: 0x04004148 RID: 16712
		private static IntPtr _ClassPtr;

		// Token: 0x04004149 RID: 16713
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400414A RID: 16714
		internal static int __PropertyOffset_FloatCurves;

		// Token: 0x0400414B RID: 16715
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FRichCurve> _FloatCurves;

		// Token: 0x0400414C RID: 16716
		internal static int __PropertyOffset_AdjustHue;

		// Token: 0x0400414D RID: 16717
		internal static int __PropertyOffset_AdjustSaturation;

		// Token: 0x0400414E RID: 16718
		internal static int __PropertyOffset_AdjustBrightness;

		// Token: 0x0400414F RID: 16719
		internal static int __PropertyOffset_AdjustBrightnessCurve;

		// Token: 0x04004150 RID: 16720
		internal static int __PropertyOffset_AdjustVibrance;

		// Token: 0x04004151 RID: 16721
		internal static int __PropertyOffset_AdjustMinAlpha;

		// Token: 0x04004152 RID: 16722
		internal static int __PropertyOffset_AdjustMaxAlpha;
	}
}
