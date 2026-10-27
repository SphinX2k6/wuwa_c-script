using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008FB RID: 2299
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BuildPromotionNewProjectSettings")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FBuildPromotionNewProjectSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007E34 RID: 32308 RVA: 0x000B5064 File Offset: 0x000B3264
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBuildPromotionNewProjectSettings._ScriptStructPtr != 0) ? FBuildPromotionNewProjectSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BuildPromotionNewProjectSettings", ref FBuildPromotionNewProjectSettings._ScriptStructPtr);
		}

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x06007E35 RID: 32309 RVA: 0x000B5088 File Offset: 0x000B3288
		// (set) Token: 0x06007E36 RID: 32310 RVA: 0x000B50CB File Offset: 0x000B32CB
		public FDirectoryPath NewProjectFolderOverride
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._NewProjectFolderOverride) == null)
				{
					result = (this._NewProjectFolderOverride = new FDirectoryPath(base.NativePtr + (IntPtr)FBuildPromotionNewProjectSettings.__PropertyOffset_NewProjectFolderOverride, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)FBuildPromotionNewProjectSettings.__PropertyOffset_NewProjectFolderOverride, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x06007E37 RID: 32311 RVA: 0x000B50EC File Offset: 0x000B32EC
		// (set) Token: 0x06007E38 RID: 32312 RVA: 0x000B5100 File Offset: 0x000B3300
		public unsafe string NewProjectNameOverride
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBuildPromotionNewProjectSettings.__PropertyOffset_NewProjectNameOverride)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBuildPromotionNewProjectSettings.__PropertyOffset_NewProjectNameOverride)), value);
			}
		}

		// Token: 0x06007E39 RID: 32313 RVA: 0x000B5115 File Offset: 0x000B3315
		public FBuildPromotionNewProjectSettings()
		{
		}

		// Token: 0x06007E3A RID: 32314 RVA: 0x000B511D File Offset: 0x000B331D
		public FBuildPromotionNewProjectSettings(FDirectoryPath NewProjectFolderOverride, string NewProjectNameOverride)
		{
			this.NewProjectFolderOverride = NewProjectFolderOverride;
			this.NewProjectNameOverride = NewProjectNameOverride;
		}

		// Token: 0x06007E3B RID: 32315 RVA: 0x000B5133 File Offset: 0x000B3333
		protected override IntPtr GetUStructPtr()
		{
			return FBuildPromotionNewProjectSettings.StaticStruct();
		}

		// Token: 0x06007E3C RID: 32316 RVA: 0x000B513F File Offset: 0x000B333F
		[NullableContext(2)]
		public FBuildPromotionNewProjectSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007E3D RID: 32317 RVA: 0x000B5149 File Offset: 0x000B3349
		public FBuildPromotionNewProjectSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007E3E RID: 32318 RVA: 0x000B5154 File Offset: 0x000B3354
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBuildPromotionNewProjectSettings(Pointer, false, true);
		}

		// Token: 0x06007E3F RID: 32319 RVA: 0x000B515E File Offset: 0x000B335E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBuildPromotionNewProjectSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04003C8C RID: 15500
		public const string __ObjectPath = "/Script/Engine.BuildPromotionNewProjectSettings";

		// Token: 0x04003C8D RID: 15501
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003C8E RID: 15502
		internal static int __PropertyOffset_NewProjectFolderOverride;

		// Token: 0x04003C8F RID: 15503
		[Nullable(2)]
		private FDirectoryPath _NewProjectFolderOverride;

		// Token: 0x04003C90 RID: 15504
		internal static int __PropertyOffset_NewProjectNameOverride;
	}
}
