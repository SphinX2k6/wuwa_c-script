using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011F6 RID: 4598
	[UnrealObjectPath("/Script/Engine.TireType")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UTireType : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010F31 RID: 69425 RVA: 0x0018E159 File Offset: 0x0018C359
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTireType._ClassPtr;
		}

		// Token: 0x06010F32 RID: 69426 RVA: 0x0018E168 File Offset: 0x0018C368
		public UTireType() : this(BuiltinUtils.AllocNativeUObject(UTireType.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010F33 RID: 69427 RVA: 0x0018E190 File Offset: 0x0018C390
		[NullableContext(1)]
		public UTireType(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTireType.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004238 RID: 16952
		// (get) Token: 0x06010F34 RID: 69428 RVA: 0x0018E1C3 File Offset: 0x0018C3C3
		// (set) Token: 0x06010F35 RID: 69429 RVA: 0x0018E1D3 File Offset: 0x0018C3D3
		public unsafe float FrictionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTireType.__PropertyOffset_FrictionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTireType.__PropertyOffset_FrictionScale) = value;
			}
		}

		// Token: 0x06010F36 RID: 69430 RVA: 0x0018E1E4 File Offset: 0x0018C3E4
		static UTireType()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TireType");
		}

		// Token: 0x06010F37 RID: 69431 RVA: 0x0018E1F2 File Offset: 0x0018C3F2
		protected UTireType(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400913F RID: 37183
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TireType";

		// Token: 0x04009140 RID: 37184
		private static IntPtr _ClassPtr;

		// Token: 0x04009141 RID: 37185
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009142 RID: 37186
		internal static int __PropertyOffset_FrictionScale;
	}
}
