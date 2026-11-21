using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001C0 RID: 448
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CurveFloat")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UCurveFloat : UCurveBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060020DE RID: 8414 RVA: 0x00030441 File Offset: 0x0002E641
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCurveFloat._ClassPtr;
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x00030450 File Offset: 0x0002E650
		public UCurveFloat() : this(BuiltinUtils.AllocNativeUObject(UCurveFloat.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x00030478 File Offset: 0x0002E678
		public UCurveFloat(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCurveFloat.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060020E1 RID: 8417 RVA: 0x000304AC File Offset: 0x0002E6AC
		// (set) Token: 0x060020E2 RID: 8418 RVA: 0x000304E5 File Offset: 0x0002E6E5
		public FRichCurve FloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._FloatCurve) == null)
				{
					result = (this._FloatCurve = new FRichCurve(base.NativePtr + (IntPtr)UCurveFloat.__PropertyOffset_FloatCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)UCurveFloat.__PropertyOffset_FloatCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x00030506 File Offset: 0x0002E706
		// (set) Token: 0x060020E4 RID: 8420 RVA: 0x00030516 File Offset: 0x0002E716
		public unsafe bool bIsEventCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCurveFloat.__PropertyOffset_bIsEventCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCurveFloat.__PropertyOffset_bIsEventCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x00030527 File Offset: 0x0002E727
		public float GetFloatValue(float InTime)
		{
			return UCurveFloat.__GetFloatValue_Internal(base.NativePtr, InTime);
		}

		// Token: 0x060020E6 RID: 8422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFloatValue_Internal(IntPtr @this, float InTime);

		// Token: 0x060020E7 RID: 8423 RVA: 0x00030535 File Offset: 0x0002E735
		static UCurveFloat()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CurveFloat");
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x00030543 File Offset: 0x0002E743
		protected UCurveFloat(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000AE8 RID: 2792
		public new const string __ObjectPath = "/Script/Engine.CurveFloat";

		// Token: 0x04000AE9 RID: 2793
		private static IntPtr _ClassPtr;

		// Token: 0x04000AEA RID: 2794
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000AEB RID: 2795
		internal static int __PropertyOffset_FloatCurve;

		// Token: 0x04000AEC RID: 2796
		[Nullable(2)]
		private FRichCurve _FloatCurve;

		// Token: 0x04000AED RID: 2797
		internal static int __PropertyOffset_bIsEventCurve;
	}
}
