using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DB3 RID: 3507
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDepthFade")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMaterialExpressionDepthFade : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE9F RID: 48799 RVA: 0x001110C6 File Offset: 0x0010F2C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDepthFade._ClassPtr;
		}

		// Token: 0x0600BEA0 RID: 48800 RVA: 0x001110D4 File Offset: 0x0010F2D4
		public UMaterialExpressionDepthFade() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDepthFade.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BEA1 RID: 48801 RVA: 0x001110FC File Offset: 0x0010F2FC
		public UMaterialExpressionDepthFade(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDepthFade.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C32 RID: 11314
		// (get) Token: 0x0600BEA2 RID: 48802 RVA: 0x00111130 File Offset: 0x0010F330
		// (set) Token: 0x0600BEA3 RID: 48803 RVA: 0x00111169 File Offset: 0x0010F369
		public FExpressionInput InOpacity
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._InOpacity) == null)
				{
					result = (this._InOpacity = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionDepthFade.__PropertyOffset_InOpacity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionDepthFade.__PropertyOffset_InOpacity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C33 RID: 11315
		// (get) Token: 0x0600BEA4 RID: 48804 RVA: 0x0011118C File Offset: 0x0010F38C
		// (set) Token: 0x0600BEA5 RID: 48805 RVA: 0x001111C5 File Offset: 0x0010F3C5
		public FExpressionInput FadeDistance
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._FadeDistance) == null)
				{
					result = (this._FadeDistance = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionDepthFade.__PropertyOffset_FadeDistance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionDepthFade.__PropertyOffset_FadeDistance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C34 RID: 11316
		// (get) Token: 0x0600BEA6 RID: 48806 RVA: 0x001111E6 File Offset: 0x0010F3E6
		// (set) Token: 0x0600BEA7 RID: 48807 RVA: 0x001111F6 File Offset: 0x0010F3F6
		public unsafe float OpacityDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionDepthFade.__PropertyOffset_OpacityDefault);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionDepthFade.__PropertyOffset_OpacityDefault) = value;
			}
		}

		// Token: 0x17002C35 RID: 11317
		// (get) Token: 0x0600BEA8 RID: 48808 RVA: 0x00111207 File Offset: 0x0010F407
		// (set) Token: 0x0600BEA9 RID: 48809 RVA: 0x00111217 File Offset: 0x0010F417
		public unsafe float FadeDistanceDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionDepthFade.__PropertyOffset_FadeDistanceDefault);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionDepthFade.__PropertyOffset_FadeDistanceDefault) = value;
			}
		}

		// Token: 0x0600BEAA RID: 48810 RVA: 0x00111228 File Offset: 0x0010F428
		static UMaterialExpressionDepthFade()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDepthFade");
		}

		// Token: 0x0600BEAB RID: 48811 RVA: 0x00111236 File Offset: 0x0010F436
		protected UMaterialExpressionDepthFade(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040064C9 RID: 25801
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDepthFade";

		// Token: 0x040064CA RID: 25802
		private static IntPtr _ClassPtr;

		// Token: 0x040064CB RID: 25803
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040064CC RID: 25804
		internal static int __PropertyOffset_InOpacity;

		// Token: 0x040064CD RID: 25805
		[Nullable(2)]
		private FExpressionInput _InOpacity;

		// Token: 0x040064CE RID: 25806
		internal static int __PropertyOffset_FadeDistance;

		// Token: 0x040064CF RID: 25807
		[Nullable(2)]
		private FExpressionInput _FadeDistance;

		// Token: 0x040064D0 RID: 25808
		internal static int __PropertyOffset_OpacityDefault;

		// Token: 0x040064D1 RID: 25809
		internal static int __PropertyOffset_FadeDistanceDefault;
	}
}
