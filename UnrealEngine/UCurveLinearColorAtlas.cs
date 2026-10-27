using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200097F RID: 2431
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CurveLinearColorAtlas")]
	[UnrealStructLayout(4096, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4096)]
	public class UCurveLinearColorAtlas : UTexture2D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600898B RID: 35211 RVA: 0x000C4FEE File Offset: 0x000C31EE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCurveLinearColorAtlas._ClassPtr;
		}

		// Token: 0x0600898C RID: 35212 RVA: 0x000C4FFC File Offset: 0x000C31FC
		public UCurveLinearColorAtlas() : this(BuiltinUtils.AllocNativeUObject(UCurveLinearColorAtlas.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600898D RID: 35213 RVA: 0x000C5024 File Offset: 0x000C3224
		public UCurveLinearColorAtlas(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCurveLinearColorAtlas.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x0600898E RID: 35214 RVA: 0x000C5057 File Offset: 0x000C3257
		// (set) Token: 0x0600898F RID: 35215 RVA: 0x000C5067 File Offset: 0x000C3267
		public unsafe uint TextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCurveLinearColorAtlas.__PropertyOffset_TextureSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCurveLinearColorAtlas.__PropertyOffset_TextureSize) = (int)value;
			}
		}

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x06008990 RID: 35216 RVA: 0x000C5078 File Offset: 0x000C3278
		// (set) Token: 0x06008991 RID: 35217 RVA: 0x000C5091 File Offset: 0x000C3291
		public unsafe bool bSquareResolution
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCurveLinearColorAtlas.__PropertyOffset_bSquareResolution) & UCurveLinearColorAtlas.__PropertyMask_bSquareResolution) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCurveLinearColorAtlas.__PropertyOffset_bSquareResolution) = ((*(base.NativePtr + (IntPtr)UCurveLinearColorAtlas.__PropertyOffset_bSquareResolution) & ~UCurveLinearColorAtlas.__PropertyMask_bSquareResolution) | (value ? UCurveLinearColorAtlas.__PropertyMask_bSquareResolution : 0));
			}
		}

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x06008992 RID: 35218 RVA: 0x000C50C1 File Offset: 0x000C32C1
		// (set) Token: 0x06008993 RID: 35219 RVA: 0x000C50D1 File Offset: 0x000C32D1
		public unsafe uint TextureHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCurveLinearColorAtlas.__PropertyOffset_TextureHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCurveLinearColorAtlas.__PropertyOffset_TextureHeight) = (int)value;
			}
		}

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x06008994 RID: 35220 RVA: 0x000C50E4 File Offset: 0x000C32E4
		// (set) Token: 0x06008995 RID: 35221 RVA: 0x000C511D File Offset: 0x000C331D
		public TArray<UCurveLinearColor> GradientCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UCurveLinearColor> result;
				if ((result = this._GradientCurves) == null)
				{
					result = (this._GradientCurves = new TArray<UCurveLinearColor>(base.NativePtr + (IntPtr)UCurveLinearColorAtlas.__PropertyOffset_GradientCurves, this));
				}
				return result;
			}
			set
			{
				this.GradientCurves.CopyAssign(value);
			}
		}

		// Token: 0x06008996 RID: 35222 RVA: 0x000C512C File Offset: 0x000C332C
		[NullableContext(2)]
		public unsafe bool GetCurvePosition(UCurveLinearColor InCurve, ref float Position)
		{
			fixed (float* ptr = &Position)
			{
				void* ptr2 = (void*)ptr;
				return UCurveLinearColorAtlas.__GetCurvePosition_Internal(base.NativePtr, (InCurve != null) ? InCurve.NativePtr : IntPtr.Zero, ref Position);
			}
		}

		// Token: 0x06008997 RID: 35223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCurvePosition_Internal(IntPtr @this, IntPtr InCurve, ref float Position);

		// Token: 0x06008998 RID: 35224 RVA: 0x000C515A File Offset: 0x000C335A
		static UCurveLinearColorAtlas()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CurveLinearColorAtlas");
		}

		// Token: 0x06008999 RID: 35225 RVA: 0x000C5168 File Offset: 0x000C3368
		protected UCurveLinearColorAtlas(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004153 RID: 16723
		public new const string __ObjectPath = "/Script/Engine.CurveLinearColorAtlas";

		// Token: 0x04004154 RID: 16724
		private static IntPtr _ClassPtr;

		// Token: 0x04004155 RID: 16725
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004156 RID: 16726
		internal static int __PropertyOffset_TextureSize;

		// Token: 0x04004157 RID: 16727
		internal static int __PropertyOffset_bSquareResolution;

		// Token: 0x04004158 RID: 16728
		internal static byte __PropertyMask_bSquareResolution;

		// Token: 0x04004159 RID: 16729
		internal static int __PropertyOffset_TextureHeight;

		// Token: 0x0400415A RID: 16730
		internal static int __PropertyOffset_GradientCurves;

		// Token: 0x0400415B RID: 16731
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UCurveLinearColor> _GradientCurves;
	}
}
