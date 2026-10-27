using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019A9 RID: 6569
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroInteractionEffect.KuroLinkNiagaraParameter")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroLinkNiagaraParameter : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601871D RID: 100125 RVA: 0x002406B6 File Offset: 0x0023E8B6
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLinkNiagaraParameter._ScriptStructPtr != 0) ? FKuroLinkNiagaraParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.KuroLinkNiagaraParameter", ref FKuroLinkNiagaraParameter._ScriptStructPtr);
		}

		// Token: 0x170061A1 RID: 24993
		// (get) Token: 0x0601871E RID: 100126 RVA: 0x002406DA File Offset: 0x0023E8DA
		// (set) Token: 0x0601871F RID: 100127 RVA: 0x002406EE File Offset: 0x0023E8EE
		public unsafe string Desc
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroLinkNiagaraParameter.__PropertyOffset_Desc)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroLinkNiagaraParameter.__PropertyOffset_Desc)), value);
			}
		}

		// Token: 0x170061A2 RID: 24994
		// (get) Token: 0x06018720 RID: 100128 RVA: 0x00240703 File Offset: 0x0023E903
		// (set) Token: 0x06018721 RID: 100129 RVA: 0x00240713 File Offset: 0x0023E913
		public unsafe int ModelConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLinkNiagaraParameter.__PropertyOffset_ModelConfigId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLinkNiagaraParameter.__PropertyOffset_ModelConfigId) = value;
			}
		}

		// Token: 0x170061A3 RID: 24995
		// (get) Token: 0x06018722 RID: 100130 RVA: 0x00240724 File Offset: 0x0023E924
		// (set) Token: 0x06018723 RID: 100131 RVA: 0x00240734 File Offset: 0x0023E934
		public unsafe int ModeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLinkNiagaraParameter.__PropertyOffset_ModeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLinkNiagaraParameter.__PropertyOffset_ModeId) = value;
			}
		}

		// Token: 0x170061A4 RID: 24996
		// (get) Token: 0x06018724 RID: 100132 RVA: 0x00240745 File Offset: 0x0023E945
		// (set) Token: 0x06018725 RID: 100133 RVA: 0x00240759 File Offset: 0x0023E959
		public unsafe FLinearColor LinkColor0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLinkNiagaraParameter.__PropertyOffset_LinkColor0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLinkNiagaraParameter.__PropertyOffset_LinkColor0) = value;
			}
		}

		// Token: 0x170061A5 RID: 24997
		// (get) Token: 0x06018726 RID: 100134 RVA: 0x0024076E File Offset: 0x0023E96E
		// (set) Token: 0x06018727 RID: 100135 RVA: 0x00240782 File Offset: 0x0023E982
		public unsafe FLinearColor LinkColor1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLinkNiagaraParameter.__PropertyOffset_LinkColor1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLinkNiagaraParameter.__PropertyOffset_LinkColor1) = value;
			}
		}

		// Token: 0x170061A6 RID: 24998
		// (get) Token: 0x06018728 RID: 100136 RVA: 0x00240797 File Offset: 0x0023E997
		// (set) Token: 0x06018729 RID: 100137 RVA: 0x002407AB File Offset: 0x0023E9AB
		public unsafe FLinearColor LinkColor2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLinkNiagaraParameter.__PropertyOffset_LinkColor2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLinkNiagaraParameter.__PropertyOffset_LinkColor2) = value;
			}
		}

		// Token: 0x0601872A RID: 100138 RVA: 0x002407C0 File Offset: 0x0023E9C0
		public FKuroLinkNiagaraParameter()
		{
		}

		// Token: 0x0601872B RID: 100139 RVA: 0x002407C8 File Offset: 0x0023E9C8
		public FKuroLinkNiagaraParameter(string Desc, int ModelConfigId, int ModeId, FLinearColor LinkColor0, FLinearColor LinkColor1, FLinearColor LinkColor2)
		{
			this.Desc = Desc;
			this.ModelConfigId = ModelConfigId;
			this.ModeId = ModeId;
			this.LinkColor0 = LinkColor0;
			this.LinkColor1 = LinkColor1;
			this.LinkColor2 = LinkColor2;
		}

		// Token: 0x0601872C RID: 100140 RVA: 0x002407FD File Offset: 0x0023E9FD
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLinkNiagaraParameter.StaticStruct();
		}

		// Token: 0x0601872D RID: 100141 RVA: 0x00240809 File Offset: 0x0023EA09
		[NullableContext(2)]
		public FKuroLinkNiagaraParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601872E RID: 100142 RVA: 0x00240813 File Offset: 0x0023EA13
		public FKuroLinkNiagaraParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601872F RID: 100143 RVA: 0x0024081E File Offset: 0x0023EA1E
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLinkNiagaraParameter(Pointer, false, true);
		}

		// Token: 0x06018730 RID: 100144 RVA: 0x00240828 File Offset: 0x0023EA28
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLinkNiagaraParameter(Pointer, MemoryOwner);
		}

		// Token: 0x0400D350 RID: 54096
		public new const string __ObjectPath = "/Script/KuroInteractionEffect.KuroLinkNiagaraParameter";

		// Token: 0x0400D351 RID: 54097
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D352 RID: 54098
		internal static int __PropertyOffset_Desc;

		// Token: 0x0400D353 RID: 54099
		internal static int __PropertyOffset_ModelConfigId;

		// Token: 0x0400D354 RID: 54100
		internal static int __PropertyOffset_ModeId;

		// Token: 0x0400D355 RID: 54101
		internal static int __PropertyOffset_LinkColor0;

		// Token: 0x0400D356 RID: 54102
		internal static int __PropertyOffset_LinkColor1;

		// Token: 0x0400D357 RID: 54103
		internal static int __PropertyOffset_LinkColor2;
	}
}
