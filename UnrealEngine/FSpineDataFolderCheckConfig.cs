using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001176 RID: 4470
	[UnrealObjectPath("/Script/Engine.SpineDataFolderCheckConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSpineDataFolderCheckConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010538 RID: 66872 RVA: 0x00180C55 File Offset: 0x0017EE55
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpineDataFolderCheckConfig._ScriptStructPtr != 0) ? FSpineDataFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SpineDataFolderCheckConfig", ref FSpineDataFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x17003FF2 RID: 16370
		// (get) Token: 0x06010539 RID: 66873 RVA: 0x00180C79 File Offset: 0x0017EE79
		// (set) Token: 0x0601053A RID: 66874 RVA: 0x00180C89 File Offset: 0x0017EE89
		public unsafe int Bones
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSpineDataFolderCheckConfig.__PropertyOffset_Bones);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSpineDataFolderCheckConfig.__PropertyOffset_Bones) = value;
			}
		}

		// Token: 0x0601053B RID: 66875 RVA: 0x00180C9A File Offset: 0x0017EE9A
		public FSpineDataFolderCheckConfig()
		{
		}

		// Token: 0x0601053C RID: 66876 RVA: 0x00180CA2 File Offset: 0x0017EEA2
		[NullableContext(1)]
		public FSpineDataFolderCheckConfig(int Bones, string Regex, int MatchingPriority)
		{
			this.Bones = Bones;
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0601053D RID: 66877 RVA: 0x00180CBF File Offset: 0x0017EEBF
		protected override IntPtr GetUStructPtr()
		{
			return FSpineDataFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0601053E RID: 66878 RVA: 0x00180CCB File Offset: 0x0017EECB
		[NullableContext(2)]
		public FSpineDataFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601053F RID: 66879 RVA: 0x00180CD5 File Offset: 0x0017EED5
		public FSpineDataFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010540 RID: 66880 RVA: 0x00180CE0 File Offset: 0x0017EEE0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpineDataFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x06010541 RID: 66881 RVA: 0x00180CEA File Offset: 0x0017EEEA
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpineDataFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04008C7B RID: 35963
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SpineDataFolderCheckConfig";

		// Token: 0x04008C7C RID: 35964
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008C7D RID: 35965
		internal static int __PropertyOffset_Bones;
	}
}
