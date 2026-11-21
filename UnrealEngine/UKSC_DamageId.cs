using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000567 RID: 1383
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DamageId")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKSC_DamageId : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007DDC RID: 32220 RVA: 0x000BA9EE File Offset: 0x000B8BEE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DamageId._ClassPtr;
		}

		// Token: 0x06007DDD RID: 32221 RVA: 0x000BA9FC File Offset: 0x000B8BFC
		public UKSC_DamageId() : this(BuiltinUtils.AllocNativeUObject(UKSC_DamageId.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007DDE RID: 32222 RVA: 0x000BAA24 File Offset: 0x000B8C24
		[NullableContext(1)]
		public UKSC_DamageId(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DamageId.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007DDF RID: 32223 RVA: 0x000BAA57 File Offset: 0x000B8C57
		public void UpdateDamageAmplify(int DamageId, float Amplify)
		{
			UKSC_DamageId.__UpdateDamageAmplify_Internal(base.NativePtr, DamageId, Amplify);
		}

		// Token: 0x06007DE0 RID: 32224 RVA: 0x000BAA66 File Offset: 0x000B8C66
		public void ClearDamageData()
		{
			UKSC_DamageId.__ClearDamageData_Internal(base.NativePtr);
		}

		// Token: 0x06007DE1 RID: 32225 RVA: 0x000BAA73 File Offset: 0x000B8C73
		[NullableContext(2)]
		public void AddDamageData(int DamageId, in FKSCDamage Data)
		{
			UKSC_DamageId.__AddDamageData_Internal(base.NativePtr, DamageId, (Data ?? new FKSCDamage()).NativePtr);
		}

		// Token: 0x06007DE2 RID: 32226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateDamageAmplify_Internal(IntPtr @this, int DamageId, float Amplify);

		// Token: 0x06007DE3 RID: 32227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearDamageData_Internal(IntPtr @this);

		// Token: 0x06007DE4 RID: 32228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddDamageData_Internal(IntPtr @this, int DamageId, IntPtr Data);

		// Token: 0x06007DE5 RID: 32229 RVA: 0x000BAA91 File Offset: 0x000B8C91
		static UKSC_DamageId()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DamageId");
		}

		// Token: 0x06007DE6 RID: 32230 RVA: 0x000BAA9F File Offset: 0x000B8C9F
		protected UKSC_DamageId(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040036DF RID: 14047
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DamageId";

		// Token: 0x040036E0 RID: 14048
		private static IntPtr _ClassPtr;

		// Token: 0x040036E1 RID: 14049
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
