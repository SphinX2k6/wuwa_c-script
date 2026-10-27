using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D45 RID: 7493
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DamageId")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKSC_DamageId : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CB1B RID: 117531 RVA: 0x002A6B22 File Offset: 0x002A4D22
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DamageId._ClassPtr;
		}

		// Token: 0x0601CB1C RID: 117532 RVA: 0x002A6B30 File Offset: 0x002A4D30
		public UKSC_DamageId() : this(BuiltinUtils.AllocNativeUObject(UKSC_DamageId.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CB1D RID: 117533 RVA: 0x002A6B58 File Offset: 0x002A4D58
		[NullableContext(1)]
		public UKSC_DamageId(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DamageId.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601CB1E RID: 117534 RVA: 0x002A6B8B File Offset: 0x002A4D8B
		public void UpdateDamageAmplify(int DamageId, float Amplify)
		{
			UKSC_DamageId.__UpdateDamageAmplify_Internal(base.NativePtr, DamageId, Amplify);
		}

		// Token: 0x0601CB1F RID: 117535 RVA: 0x002A6B9A File Offset: 0x002A4D9A
		public void ClearDamageData()
		{
			UKSC_DamageId.__ClearDamageData_Internal(base.NativePtr);
		}

		// Token: 0x0601CB20 RID: 117536 RVA: 0x002A6BA7 File Offset: 0x002A4DA7
		[NullableContext(2)]
		public void AddDamageData(int DamageId, in FKSCDamage Data)
		{
			UKSC_DamageId.__AddDamageData_Internal(base.NativePtr, DamageId, (Data ?? new FKSCDamage()).NativePtr);
		}

		// Token: 0x0601CB21 RID: 117537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateDamageAmplify_Internal(IntPtr @this, int DamageId, float Amplify);

		// Token: 0x0601CB22 RID: 117538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearDamageData_Internal(IntPtr @this);

		// Token: 0x0601CB23 RID: 117539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddDamageData_Internal(IntPtr @this, int DamageId, IntPtr Data);

		// Token: 0x0601CB24 RID: 117540 RVA: 0x002A6BC5 File Offset: 0x002A4DC5
		static UKSC_DamageId()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DamageId");
		}

		// Token: 0x0601CB25 RID: 117541 RVA: 0x002A6BD3 File Offset: 0x002A4DD3
		protected UKSC_DamageId(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8EB RID: 63723
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DamageId";

		// Token: 0x0400F8EC RID: 63724
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8ED RID: 63725
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
