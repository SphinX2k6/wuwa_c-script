using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200172A RID: 5930
	[UnrealObjectPath("/Script/KuroBullet.HitEffectManager")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UHitEffectManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015599 RID: 87449 RVA: 0x001F5F8D File Offset: 0x001F418D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHitEffectManager._ClassPtr;
		}

		// Token: 0x0601559A RID: 87450 RVA: 0x001F5F9C File Offset: 0x001F419C
		public UHitEffectManager() : this(BuiltinUtils.AllocNativeUObject(UHitEffectManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601559B RID: 87451 RVA: 0x001F5FC4 File Offset: 0x001F41C4
		[NullableContext(1)]
		public UHitEffectManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHitEffectManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005454 RID: 21588
		// (get) Token: 0x0601559C RID: 87452 RVA: 0x001F5FF7 File Offset: 0x001F41F7
		// (set) Token: 0x0601559D RID: 87453 RVA: 0x001F6007 File Offset: 0x001F4207
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

		// Token: 0x17005455 RID: 21589
		// (get) Token: 0x0601559E RID: 87454 RVA: 0x001F6018 File Offset: 0x001F4218
		// (set) Token: 0x0601559F RID: 87455 RVA: 0x001F6028 File Offset: 0x001F4228
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

		// Token: 0x17005456 RID: 21590
		// (get) Token: 0x060155A0 RID: 87456 RVA: 0x001F6039 File Offset: 0x001F4239
		// (set) Token: 0x060155A1 RID: 87457 RVA: 0x001F6049 File Offset: 0x001F4249
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

		// Token: 0x060155A2 RID: 87458 RVA: 0x001F605A File Offset: 0x001F425A
		static UHitEffectManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.HitEffectManager");
		}

		// Token: 0x060155A3 RID: 87459 RVA: 0x001F6068 File Offset: 0x001F4268
		protected UHitEffectManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BA49 RID: 47689
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.HitEffectManager";

		// Token: 0x0400BA4A RID: 47690
		private static IntPtr _ClassPtr;

		// Token: 0x0400BA4B RID: 47691
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BA4C RID: 47692
		internal static int __PropertyOffset_MaxEffectCountPerPath;

		// Token: 0x0400BA4D RID: 47693
		internal static int __PropertyOffset_MaxEffectCountPerFrame;

		// Token: 0x0400BA4E RID: 47694
		internal static int __PropertyOffset_ExpiredTime;
	}
}
