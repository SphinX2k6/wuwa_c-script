using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003DF RID: 991
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectAudioContext")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKuroEffectAudioContext : FKuroEffectContext, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006156 RID: 24918 RVA: 0x0008B2BC File Offset: 0x000894BC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEffectAudioContext._ScriptStructPtr != 0) ? FKuroEffectAudioContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroEffectAudioContext", ref FKuroEffectAudioContext._ScriptStructPtr);
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x06006157 RID: 24919 RVA: 0x0008B2E0 File Offset: 0x000894E0
		// (set) Token: 0x06006158 RID: 24920 RVA: 0x0008B2F0 File Offset: 0x000894F0
		public unsafe bool FromPrimaryRole
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectAudioContext.__PropertyOffset_FromPrimaryRole) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectAudioContext.__PropertyOffset_FromPrimaryRole) = (value ? 1 : 0);
			}
		}

		// Token: 0x06006159 RID: 24921 RVA: 0x0008B301 File Offset: 0x00089501
		public FKuroEffectAudioContext()
		{
		}

		// Token: 0x0600615A RID: 24922 RVA: 0x0008B309 File Offset: 0x00089509
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEffectAudioContext.StaticStruct();
		}

		// Token: 0x0600615B RID: 24923 RVA: 0x0008B315 File Offset: 0x00089515
		[NullableContext(2)]
		public FKuroEffectAudioContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600615C RID: 24924 RVA: 0x0008B31F File Offset: 0x0008951F
		public FKuroEffectAudioContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600615D RID: 24925 RVA: 0x0008B32A File Offset: 0x0008952A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEffectAudioContext(Pointer, false, true);
		}

		// Token: 0x0600615E RID: 24926 RVA: 0x0008B334 File Offset: 0x00089534
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEffectAudioContext(Pointer, MemoryOwner);
		}

		// Token: 0x04002984 RID: 10628
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroEffectAudioContext";

		// Token: 0x04002985 RID: 10629
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002986 RID: 10630
		internal static int __PropertyOffset_FromPrimaryRole;
	}
}
