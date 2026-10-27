using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CDF RID: 3295
	[UnrealObjectPath("/Script/Engine.KuroAnimSequenceFolderCheckConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroAnimSequenceFolderCheckConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AEC0 RID: 44736 RVA: 0x000F7EC7 File Offset: 0x000F60C7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroAnimSequenceFolderCheckConfig._ScriptStructPtr != 0) ? FKuroAnimSequenceFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroAnimSequenceFolderCheckConfig", ref FKuroAnimSequenceFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x17002778 RID: 10104
		// (get) Token: 0x0600AEC1 RID: 44737 RVA: 0x000F7EEB File Offset: 0x000F60EB
		// (set) Token: 0x0600AEC2 RID: 44738 RVA: 0x000F7EFB File Offset: 0x000F60FB
		public unsafe float MaxFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroAnimSequenceFolderCheckConfig.__PropertyOffset_MaxFrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroAnimSequenceFolderCheckConfig.__PropertyOffset_MaxFrameRate) = value;
			}
		}

		// Token: 0x0600AEC3 RID: 44739 RVA: 0x000F7F0C File Offset: 0x000F610C
		public FKuroAnimSequenceFolderCheckConfig()
		{
		}

		// Token: 0x0600AEC4 RID: 44740 RVA: 0x000F7F14 File Offset: 0x000F6114
		[NullableContext(1)]
		public FKuroAnimSequenceFolderCheckConfig(float MaxFrameRate, string Regex, int MatchingPriority)
		{
			this.MaxFrameRate = MaxFrameRate;
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600AEC5 RID: 44741 RVA: 0x000F7F31 File Offset: 0x000F6131
		protected override IntPtr GetUStructPtr()
		{
			return FKuroAnimSequenceFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600AEC6 RID: 44742 RVA: 0x000F7F3D File Offset: 0x000F613D
		[NullableContext(2)]
		public FKuroAnimSequenceFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AEC7 RID: 44743 RVA: 0x000F7F47 File Offset: 0x000F6147
		public FKuroAnimSequenceFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AEC8 RID: 44744 RVA: 0x000F7F52 File Offset: 0x000F6152
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroAnimSequenceFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600AEC9 RID: 44745 RVA: 0x000F7F5C File Offset: 0x000F615C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroAnimSequenceFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005B8B RID: 23435
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KuroAnimSequenceFolderCheckConfig";

		// Token: 0x04005B8C RID: 23436
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005B8D RID: 23437
		internal static int __PropertyOffset_MaxFrameRate;
	}
}
