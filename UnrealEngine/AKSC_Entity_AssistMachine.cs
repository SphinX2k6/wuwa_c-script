using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DDD RID: 7645
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Entity_AssistMachine")]
	[UnrealStructLayout(1384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1384)]
	public class AKSC_Entity_AssistMachine : AKSC_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D37D RID: 119677 RVA: 0x002B2620 File Offset: 0x002B0820
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Entity_AssistMachine._ClassPtr;
		}

		// Token: 0x0601D37E RID: 119678 RVA: 0x002B262C File Offset: 0x002B082C
		public AKSC_Entity_AssistMachine() : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity_AssistMachine.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D37F RID: 119679 RVA: 0x002B2654 File Offset: 0x002B0854
		public AKSC_Entity_AssistMachine(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity_AssistMachine.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170075FB RID: 30203
		// (get) Token: 0x0601D380 RID: 119680 RVA: 0x002B2687 File Offset: 0x002B0887
		// (set) Token: 0x0601D381 RID: 119681 RVA: 0x002B269B File Offset: 0x002B089B
		[Nullable(2)]
		public unsafe UKSC_DA_Entity_AssistMachine DaEntity_AssistMachine_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Entity_AssistMachine>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity_AssistMachine.__PropertyOffset_DaEntity_AssistMachine_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity_AssistMachine.__PropertyOffset_DaEntity_AssistMachine_, value);
			}
		}

		// Token: 0x170075FC RID: 30204
		// (get) Token: 0x0601D382 RID: 119682 RVA: 0x002B26B0 File Offset: 0x002B08B0
		// (set) Token: 0x0601D383 RID: 119683 RVA: 0x002B26C0 File Offset: 0x002B08C0
		public unsafe int ListenCDSkillIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKSC_Entity_AssistMachine.__PropertyOffset_ListenCDSkillIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKSC_Entity_AssistMachine.__PropertyOffset_ListenCDSkillIndex) = value;
			}
		}

		// Token: 0x170075FD RID: 30205
		// (get) Token: 0x0601D384 RID: 119684 RVA: 0x002B26D4 File Offset: 0x002B08D4
		// (set) Token: 0x0601D385 RID: 119685 RVA: 0x002B270D File Offset: 0x002B090D
		public FOnSkillCD OnSkillCD
		{
			get
			{
				base.FastCheckIsValid();
				FOnSkillCD result;
				if ((result = this._OnSkillCD) == null)
				{
					result = (this._OnSkillCD = new FOnSkillCD(base.NativePtr + (IntPtr)AKSC_Entity_AssistMachine.__PropertyOffset_OnSkillCD, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AKSC_Entity_AssistMachine.__PropertyOffset_OnSkillCD, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170075FE RID: 30206
		// (get) Token: 0x0601D386 RID: 119686 RVA: 0x002B272E File Offset: 0x002B092E
		// (set) Token: 0x0601D387 RID: 119687 RVA: 0x002B273E File Offset: 0x002B093E
		public unsafe int ListenSkillReadyIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKSC_Entity_AssistMachine.__PropertyOffset_ListenSkillReadyIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKSC_Entity_AssistMachine.__PropertyOffset_ListenSkillReadyIndex) = value;
			}
		}

		// Token: 0x170075FF RID: 30207
		// (get) Token: 0x0601D388 RID: 119688 RVA: 0x002B2750 File Offset: 0x002B0950
		// (set) Token: 0x0601D389 RID: 119689 RVA: 0x002B2789 File Offset: 0x002B0989
		public FOnSkillReady OnSkillReady
		{
			get
			{
				base.FastCheckIsValid();
				FOnSkillReady result;
				if ((result = this._OnSkillReady) == null)
				{
					result = (this._OnSkillReady = new FOnSkillReady(base.NativePtr + (IntPtr)AKSC_Entity_AssistMachine.__PropertyOffset_OnSkillReady, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AKSC_Entity_AssistMachine.__PropertyOffset_OnSkillReady, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601D38A RID: 119690 RVA: 0x002B27AC File Offset: 0x002B09AC
		public unsafe void SetSkillAutoCast(in int SkillIndex, EKSC_SkillAutoCast AutoCast)
		{
			fixed (int* ptr = &SkillIndex)
			{
				void* ptr2 = (void*)ptr;
				AKSC_Entity_AssistMachine.__SetSkillAutoCast_Internal(base.NativePtr, SkillIndex, AutoCast);
			}
		}

		// Token: 0x0601D38B RID: 119691 RVA: 0x002B27D0 File Offset: 0x002B09D0
		public unsafe void D_Fire(in FTransformDouble D_FireTrans, int SkillIndex)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = D_FireTrans;
			AKSC_Entity_AssistMachine.__D_Fire_Internal(base.NativePtr, ptr, SkillIndex);
		}

		// Token: 0x0601D38C RID: 119692
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkillAutoCast_Internal(IntPtr @this, in int SkillIndex, EKSC_SkillAutoCast AutoCast);

		// Token: 0x0601D38D RID: 119693
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_Fire_Internal(IntPtr @this, in FTransformDouble D_FireTrans, int SkillIndex);

		// Token: 0x0601D38E RID: 119694 RVA: 0x002B2806 File Offset: 0x002B0A06
		static AKSC_Entity_AssistMachine()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Entity_AssistMachine");
		}

		// Token: 0x0601D38F RID: 119695 RVA: 0x002B2814 File Offset: 0x002B0A14
		protected AKSC_Entity_AssistMachine(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FDAE RID: 64942
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Entity_AssistMachine";

		// Token: 0x0400FDAF RID: 64943
		private static IntPtr _ClassPtr;

		// Token: 0x0400FDB0 RID: 64944
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FDB1 RID: 64945
		public static IntPtr __OnSkillReady__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FDB2 RID: 64946
		public static IntPtr __OnSkillCD__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FDB3 RID: 64947
		internal static int __PropertyOffset_DaEntity_AssistMachine_;

		// Token: 0x0400FDB4 RID: 64948
		internal static int __PropertyOffset_ListenCDSkillIndex;

		// Token: 0x0400FDB5 RID: 64949
		internal static int __PropertyOffset_OnSkillCD;

		// Token: 0x0400FDB6 RID: 64950
		[Nullable(2)]
		private FOnSkillCD _OnSkillCD;

		// Token: 0x0400FDB7 RID: 64951
		internal static int __PropertyOffset_ListenSkillReadyIndex;

		// Token: 0x0400FDB8 RID: 64952
		internal static int __PropertyOffset_OnSkillReady;

		// Token: 0x0400FDB9 RID: 64953
		[Nullable(2)]
		private FOnSkillReady _OnSkillReady;
	}
}
