using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003C0 RID: 960
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelBillboard")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UEffectModelBillboard : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005DEC RID: 24044 RVA: 0x00084C14 File Offset: 0x00082E14
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelBillboard._ClassPtr;
		}

		// Token: 0x06005DED RID: 24045 RVA: 0x00084C20 File Offset: 0x00082E20
		public UEffectModelBillboard() : this(BuiltinUtils.AllocNativeUObject(UEffectModelBillboard.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005DEE RID: 24046 RVA: 0x00084C48 File Offset: 0x00082E48
		[NullableContext(1)]
		public UEffectModelBillboard(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelBillboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x06005DEF RID: 24047 RVA: 0x00084C7B File Offset: 0x00082E7B
		// (set) Token: 0x06005DF0 RID: 24048 RVA: 0x00084C8B File Offset: 0x00082E8B
		public unsafe bool IsUpdateEveryFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_IsUpdateEveryFrame) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_IsUpdateEveryFrame) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x06005DF1 RID: 24049 RVA: 0x00084C9C File Offset: 0x00082E9C
		// (set) Token: 0x06005DF2 RID: 24050 RVA: 0x00084CAC File Offset: 0x00082EAC
		public unsafe bool IsFixSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_IsFixSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_IsFixSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x06005DF3 RID: 24051 RVA: 0x00084CBD File Offset: 0x00082EBD
		// (set) Token: 0x06005DF4 RID: 24052 RVA: 0x00084CCD File Offset: 0x00082ECD
		public unsafe float ScaleSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_ScaleSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_ScaleSize) = value;
			}
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x06005DF5 RID: 24053 RVA: 0x00084CDE File Offset: 0x00082EDE
		// (set) Token: 0x06005DF6 RID: 24054 RVA: 0x00084CEE File Offset: 0x00082EEE
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_MaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_MaxDistance) = value;
			}
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x06005DF7 RID: 24055 RVA: 0x00084CFF File Offset: 0x00082EFF
		// (set) Token: 0x06005DF8 RID: 24056 RVA: 0x00084D0F File Offset: 0x00082F0F
		public unsafe float MinSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_MinSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_MinSize) = value;
			}
		}

		// Token: 0x06005DF9 RID: 24057 RVA: 0x00084D20 File Offset: 0x00082F20
		static UEffectModelBillboard()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelBillboard");
		}

		// Token: 0x06005DFA RID: 24058 RVA: 0x00084D2E File Offset: 0x00082F2E
		protected UEffectModelBillboard(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400272A RID: 10026
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelBillboard";

		// Token: 0x0400272B RID: 10027
		private static IntPtr _ClassPtr;

		// Token: 0x0400272C RID: 10028
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400272D RID: 10029
		internal static int __PropertyOffset_IsUpdateEveryFrame;

		// Token: 0x0400272E RID: 10030
		internal static int __PropertyOffset_IsFixSize;

		// Token: 0x0400272F RID: 10031
		internal static int __PropertyOffset_ScaleSize;

		// Token: 0x04002730 RID: 10032
		internal static int __PropertyOffset_MaxDistance;

		// Token: 0x04002731 RID: 10033
		internal static int __PropertyOffset_MinSize;
	}
}
