using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E6C RID: 3692
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTime")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UMaterialExpressionTime : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C581 RID: 50561 RVA: 0x0011DF81 File Offset: 0x0011C181
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTime._ClassPtr;
		}

		// Token: 0x0600C582 RID: 50562 RVA: 0x0011DF90 File Offset: 0x0011C190
		public UMaterialExpressionTime() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTime.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C583 RID: 50563 RVA: 0x0011DFB8 File Offset: 0x0011C1B8
		[NullableContext(1)]
		public UMaterialExpressionTime(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTime.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DD7 RID: 11735
		// (get) Token: 0x0600C584 RID: 50564 RVA: 0x0011DFEB File Offset: 0x0011C1EB
		// (set) Token: 0x0600C585 RID: 50565 RVA: 0x0011E004 File Offset: 0x0011C204
		public unsafe bool bIgnorePause
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionTime.__PropertyOffset_bIgnorePause) & UMaterialExpressionTime.__PropertyMask_bIgnorePause) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionTime.__PropertyOffset_bIgnorePause) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionTime.__PropertyOffset_bIgnorePause) & ~UMaterialExpressionTime.__PropertyMask_bIgnorePause) | (value ? UMaterialExpressionTime.__PropertyMask_bIgnorePause : 0));
			}
		}

		// Token: 0x17002DD8 RID: 11736
		// (get) Token: 0x0600C586 RID: 50566 RVA: 0x0011E034 File Offset: 0x0011C234
		// (set) Token: 0x0600C587 RID: 50567 RVA: 0x0011E04D File Offset: 0x0011C24D
		public unsafe bool bOverride_Period
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionTime.__PropertyOffset_bOverride_Period) & UMaterialExpressionTime.__PropertyMask_bOverride_Period) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionTime.__PropertyOffset_bOverride_Period) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionTime.__PropertyOffset_bOverride_Period) & ~UMaterialExpressionTime.__PropertyMask_bOverride_Period) | (value ? UMaterialExpressionTime.__PropertyMask_bOverride_Period : 0));
			}
		}

		// Token: 0x17002DD9 RID: 11737
		// (get) Token: 0x0600C588 RID: 50568 RVA: 0x0011E07D File Offset: 0x0011C27D
		// (set) Token: 0x0600C589 RID: 50569 RVA: 0x0011E08D File Offset: 0x0011C28D
		public unsafe float Period
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionTime.__PropertyOffset_Period);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionTime.__PropertyOffset_Period) = value;
			}
		}

		// Token: 0x0600C58A RID: 50570 RVA: 0x0011E09E File Offset: 0x0011C29E
		static UMaterialExpressionTime()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTime");
		}

		// Token: 0x0600C58B RID: 50571 RVA: 0x0011E0AC File Offset: 0x0011C2AC
		protected UMaterialExpressionTime(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069A4 RID: 27044
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTime";

		// Token: 0x040069A5 RID: 27045
		private static IntPtr _ClassPtr;

		// Token: 0x040069A6 RID: 27046
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040069A7 RID: 27047
		internal static int __PropertyOffset_bIgnorePause;

		// Token: 0x040069A8 RID: 27048
		internal static byte __PropertyMask_bIgnorePause;

		// Token: 0x040069A9 RID: 27049
		internal static int __PropertyOffset_bOverride_Period;

		// Token: 0x040069AA RID: 27050
		internal static byte __PropertyMask_bOverride_Period;

		// Token: 0x040069AB RID: 27051
		internal static int __PropertyOffset_Period;
	}
}
