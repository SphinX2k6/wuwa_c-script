using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000334 RID: 820
	[UnrealObjectPath("/Script/KuroBullet.HitEffectManager")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UHitEffectManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005568 RID: 21864 RVA: 0x00077731 File Offset: 0x00075931
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHitEffectManager._ClassPtr;
		}

		// Token: 0x06005569 RID: 21865 RVA: 0x00077740 File Offset: 0x00075940
		public UHitEffectManager() : this(BuiltinUtils.AllocNativeUObject(UHitEffectManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600556A RID: 21866 RVA: 0x00077768 File Offset: 0x00075968
		[NullableContext(1)]
		public UHitEffectManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHitEffectManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x0600556B RID: 21867 RVA: 0x0007779B File Offset: 0x0007599B
		// (set) Token: 0x0600556C RID: 21868 RVA: 0x000777AB File Offset: 0x000759AB
		public unsafe int MaxEffectCountPerPath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHitEffectManager.__PropertyOffset_MaxEffectCountPerPath);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHitEffectManager.__PropertyOffset_MaxEffectCountPerPath) = value;
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x0600556D RID: 21869 RVA: 0x000777BC File Offset: 0x000759BC
		// (set) Token: 0x0600556E RID: 21870 RVA: 0x000777CC File Offset: 0x000759CC
		public unsafe int MaxEffectCountPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHitEffectManager.__PropertyOffset_MaxEffectCountPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHitEffectManager.__PropertyOffset_MaxEffectCountPerFrame) = value;
			}
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x0600556F RID: 21871 RVA: 0x000777DD File Offset: 0x000759DD
		// (set) Token: 0x06005570 RID: 21872 RVA: 0x000777ED File Offset: 0x000759ED
		public unsafe float ExpiredTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHitEffectManager.__PropertyOffset_ExpiredTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHitEffectManager.__PropertyOffset_ExpiredTime) = value;
			}
		}

		// Token: 0x06005571 RID: 21873 RVA: 0x000777FE File Offset: 0x000759FE
		static UHitEffectManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.HitEffectManager");
		}

		// Token: 0x06005572 RID: 21874 RVA: 0x0007780C File Offset: 0x00075A0C
		protected UHitEffectManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040022E5 RID: 8933
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.HitEffectManager";

		// Token: 0x040022E6 RID: 8934
		private static IntPtr _ClassPtr;

		// Token: 0x040022E7 RID: 8935
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040022E8 RID: 8936
		internal static int __PropertyOffset_MaxEffectCountPerPath;

		// Token: 0x040022E9 RID: 8937
		internal static int __PropertyOffset_MaxEffectCountPerFrame;

		// Token: 0x040022EA RID: 8938
		internal static int __PropertyOffset_ExpiredTime;
	}
}
