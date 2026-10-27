using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018C4 RID: 6340
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectAudioContext")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKuroEffectAudioContext : FKuroEffectContext, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060176DD RID: 95965 RVA: 0x00224345 File Offset: 0x00222545
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEffectAudioContext._ScriptStructPtr != 0) ? FKuroEffectAudioContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroEffectAudioContext", ref FKuroEffectAudioContext._ScriptStructPtr);
		}

		// Token: 0x17005E9C RID: 24220
		// (get) Token: 0x060176DE RID: 95966 RVA: 0x00224369 File Offset: 0x00222569
		// (set) Token: 0x060176DF RID: 95967 RVA: 0x00224379 File Offset: 0x00222579
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

		// Token: 0x060176E0 RID: 95968 RVA: 0x0022438A File Offset: 0x0022258A
		public FKuroEffectAudioContext()
		{
		}

		// Token: 0x060176E1 RID: 95969 RVA: 0x00224394 File Offset: 0x00222594
		[NullableContext(1)]
		public FKuroEffectAudioContext(bool FromPrimaryRole, int EntityId, UObject SourceObject, bool DisablePostProcess, int CreateFromType, int PlayFlag, bool CreateFromBpEffectActor, byte ContextType, int HitEffectType, FName AnsSlotName)
		{
			this.FromPrimaryRole = FromPrimaryRole;
			base.EntityId = EntityId;
			base.SourceObject = SourceObject;
			base.DisablePostProcess = DisablePostProcess;
			base.CreateFromType = CreateFromType;
			base.PlayFlag = PlayFlag;
			base.CreateFromBpEffectActor = CreateFromBpEffectActor;
			base.ContextType = ContextType;
			base.HitEffectType = HitEffectType;
			base.AnsSlotName = AnsSlotName;
		}

		// Token: 0x060176E2 RID: 95970 RVA: 0x002243F4 File Offset: 0x002225F4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEffectAudioContext.StaticStruct();
		}

		// Token: 0x060176E3 RID: 95971 RVA: 0x00224400 File Offset: 0x00222600
		[NullableContext(2)]
		public FKuroEffectAudioContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060176E4 RID: 95972 RVA: 0x0022440A File Offset: 0x0022260A
		public FKuroEffectAudioContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060176E5 RID: 95973 RVA: 0x00224415 File Offset: 0x00222615
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEffectAudioContext(Pointer, false, true);
		}

		// Token: 0x060176E6 RID: 95974 RVA: 0x0022441F File Offset: 0x0022261F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEffectAudioContext(Pointer, MemoryOwner);
		}

		// Token: 0x0400CBE3 RID: 52195
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroEffectAudioContext";

		// Token: 0x0400CBE4 RID: 52196
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CBE5 RID: 52197
		internal static int __PropertyOffset_FromPrimaryRole;
	}
}
