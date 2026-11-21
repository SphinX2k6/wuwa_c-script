using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000579 RID: 1401
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Entity_AssistMachine")]
	[UnrealStructLayout(1384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1384)]
	public class AKSC_Entity_AssistMachine : AKSC_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007F82 RID: 32642 RVA: 0x000BCA4C File Offset: 0x000BAC4C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Entity_AssistMachine._ClassPtr;
		}

		// Token: 0x06007F83 RID: 32643 RVA: 0x000BCA58 File Offset: 0x000BAC58
		public AKSC_Entity_AssistMachine() : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity_AssistMachine.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007F84 RID: 32644 RVA: 0x000BCA80 File Offset: 0x000BAC80
		public AKSC_Entity_AssistMachine(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity_AssistMachine.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x06007F85 RID: 32645 RVA: 0x000BCAB3 File Offset: 0x000BACB3
		// (set) Token: 0x06007F86 RID: 32646 RVA: 0x000BCAC3 File Offset: 0x000BACC3
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

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x06007F87 RID: 32647 RVA: 0x000BCAD4 File Offset: 0x000BACD4
		// (set) Token: 0x06007F88 RID: 32648 RVA: 0x000BCB0D File Offset: 0x000BAD0D
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

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x06007F89 RID: 32649 RVA: 0x000BCB2E File Offset: 0x000BAD2E
		// (set) Token: 0x06007F8A RID: 32650 RVA: 0x000BCB3E File Offset: 0x000BAD3E
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

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x06007F8B RID: 32651 RVA: 0x000BCB50 File Offset: 0x000BAD50
		// (set) Token: 0x06007F8C RID: 32652 RVA: 0x000BCB89 File Offset: 0x000BAD89
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

		// Token: 0x06007F8D RID: 32653 RVA: 0x000BCBAC File Offset: 0x000BADAC
		public unsafe void SetSkillAutoCast(in int SkillIndex, EKSC_SkillAutoCast AutoCast)
		{
			fixed (int* ptr = &SkillIndex)
			{
				void* ptr2 = (void*)ptr;
				AKSC_Entity_AssistMachine.__SetSkillAutoCast_Internal(base.NativePtr, SkillIndex, AutoCast);
			}
		}

		// Token: 0x06007F8E RID: 32654 RVA: 0x000BCBD0 File Offset: 0x000BADD0
		public unsafe void D_Fire(in FTransformDouble D_FireTrans, int SkillIndex)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = D_FireTrans;
			AKSC_Entity_AssistMachine.__D_Fire_Internal(base.NativePtr, ptr, SkillIndex);
		}

		// Token: 0x06007F8F RID: 32655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkillAutoCast_Internal(IntPtr @this, in int SkillIndex, EKSC_SkillAutoCast AutoCast);

		// Token: 0x06007F90 RID: 32656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_Fire_Internal(IntPtr @this, in FTransformDouble D_FireTrans, int SkillIndex);

		// Token: 0x06007F91 RID: 32657 RVA: 0x000BCC06 File Offset: 0x000BAE06
		static AKSC_Entity_AssistMachine()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Entity_AssistMachine");
		}

		// Token: 0x06007F92 RID: 32658 RVA: 0x000BCC14 File Offset: 0x000BAE14
		protected AKSC_Entity_AssistMachine(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040037AE RID: 14254
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Entity_AssistMachine";

		// Token: 0x040037AF RID: 14255
		private static IntPtr _ClassPtr;

		// Token: 0x040037B0 RID: 14256
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040037B1 RID: 14257
		public static IntPtr __OnSkillReady__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040037B2 RID: 14258
		public static IntPtr __OnSkillCD__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040037B3 RID: 14259
		internal static int __PropertyOffset_ListenCDSkillIndex;

		// Token: 0x040037B4 RID: 14260
		internal static int __PropertyOffset_OnSkillCD;

		// Token: 0x040037B5 RID: 14261
		[Nullable(2)]
		private FOnSkillCD _OnSkillCD;

		// Token: 0x040037B6 RID: 14262
		internal static int __PropertyOffset_ListenSkillReadyIndex;

		// Token: 0x040037B7 RID: 14263
		internal static int __PropertyOffset_OnSkillReady;

		// Token: 0x040037B8 RID: 14264
		[Nullable(2)]
		private FOnSkillReady _OnSkillReady;
	}
}
