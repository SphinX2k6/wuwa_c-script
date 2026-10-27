using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C3E RID: 3134
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HLODVersionInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FHLODVersionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009EC0 RID: 40640 RVA: 0x000E19F5 File Offset: 0x000DFBF5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHLODVersionInfo._ScriptStructPtr != 0) ? FHLODVersionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HLODVersionInfo", ref FHLODVersionInfo._ScriptStructPtr);
		}

		// Token: 0x170025EA RID: 9706
		// (get) Token: 0x06009EC1 RID: 40641 RVA: 0x000E1A19 File Offset: 0x000DFC19
		// (set) Token: 0x06009EC2 RID: 40642 RVA: 0x000E1A2D File Offset: 0x000DFC2D
		public unsafe string HLODVersion
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHLODVersionInfo.__PropertyOffset_HLODVersion)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHLODVersionInfo.__PropertyOffset_HLODVersion)), value);
			}
		}

		// Token: 0x170025EB RID: 9707
		// (get) Token: 0x06009EC3 RID: 40643 RVA: 0x000E1A44 File Offset: 0x000DFC44
		// (set) Token: 0x06009EC4 RID: 40644 RVA: 0x000E1A87 File Offset: 0x000DFC87
		public TArray<string> HLODActorLabels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._HLODActorLabels) == null)
				{
					result = (this._HLODActorLabels = new TArray<string>(base.NativePtr + (IntPtr)FHLODVersionInfo.__PropertyOffset_HLODActorLabels, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HLODActorLabels.CopyAssign(value);
			}
		}

		// Token: 0x06009EC5 RID: 40645 RVA: 0x000E1A95 File Offset: 0x000DFC95
		public FHLODVersionInfo()
		{
		}

		// Token: 0x06009EC6 RID: 40646 RVA: 0x000E1A9D File Offset: 0x000DFC9D
		public FHLODVersionInfo(string HLODVersion, TArray<string> HLODActorLabels)
		{
			this.HLODVersion = HLODVersion;
			this.HLODActorLabels = HLODActorLabels;
		}

		// Token: 0x06009EC7 RID: 40647 RVA: 0x000E1AB3 File Offset: 0x000DFCB3
		protected override IntPtr GetUStructPtr()
		{
			return FHLODVersionInfo.StaticStruct();
		}

		// Token: 0x06009EC8 RID: 40648 RVA: 0x000E1ABF File Offset: 0x000DFCBF
		[NullableContext(2)]
		public FHLODVersionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009EC9 RID: 40649 RVA: 0x000E1AC9 File Offset: 0x000DFCC9
		public FHLODVersionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009ECA RID: 40650 RVA: 0x000E1AD4 File Offset: 0x000DFCD4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHLODVersionInfo(Pointer, false, true);
		}

		// Token: 0x06009ECB RID: 40651 RVA: 0x000E1ADE File Offset: 0x000DFCDE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHLODVersionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04005783 RID: 22403
		public const string __ObjectPath = "/Script/Engine.HLODVersionInfo";

		// Token: 0x04005784 RID: 22404
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005785 RID: 22405
		internal static int __PropertyOffset_HLODVersion;

		// Token: 0x04005786 RID: 22406
		internal static int __PropertyOffset_HLODActorLabels;

		// Token: 0x04005787 RID: 22407
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _HLODActorLabels;
	}
}
