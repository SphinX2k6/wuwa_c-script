using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015AA RID: 5546
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/IOSRuntimeSettings.IOSBuildResourceDirectory")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FIOSBuildResourceDirectory : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013F6D RID: 81773 RVA: 0x001D5006 File Offset: 0x001D3206
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIOSBuildResourceDirectory._ScriptStructPtr != 0) ? FIOSBuildResourceDirectory._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/IOSRuntimeSettings.IOSBuildResourceDirectory", ref FIOSBuildResourceDirectory._ScriptStructPtr);
		}

		// Token: 0x17004E2F RID: 20015
		// (get) Token: 0x06013F6E RID: 81774 RVA: 0x001D502A File Offset: 0x001D322A
		// (set) Token: 0x06013F6F RID: 81775 RVA: 0x001D503E File Offset: 0x001D323E
		public unsafe string Path
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FIOSBuildResourceDirectory.__PropertyOffset_Path)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FIOSBuildResourceDirectory.__PropertyOffset_Path)), value);
			}
		}

		// Token: 0x06013F70 RID: 81776 RVA: 0x001D5053 File Offset: 0x001D3253
		public FIOSBuildResourceDirectory()
		{
		}

		// Token: 0x06013F71 RID: 81777 RVA: 0x001D505B File Offset: 0x001D325B
		public FIOSBuildResourceDirectory(string Path)
		{
			this.Path = Path;
		}

		// Token: 0x06013F72 RID: 81778 RVA: 0x001D506A File Offset: 0x001D326A
		protected override IntPtr GetUStructPtr()
		{
			return FIOSBuildResourceDirectory.StaticStruct();
		}

		// Token: 0x06013F73 RID: 81779 RVA: 0x001D5076 File Offset: 0x001D3276
		[NullableContext(2)]
		public FIOSBuildResourceDirectory(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013F74 RID: 81780 RVA: 0x001D5080 File Offset: 0x001D3280
		public FIOSBuildResourceDirectory(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013F75 RID: 81781 RVA: 0x001D508B File Offset: 0x001D328B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIOSBuildResourceDirectory(Pointer, false, true);
		}

		// Token: 0x06013F76 RID: 81782 RVA: 0x001D5095 File Offset: 0x001D3295
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIOSBuildResourceDirectory(Pointer, MemoryOwner);
		}

		// Token: 0x0400AD70 RID: 44400
		public const string __ObjectPath = "/Script/IOSRuntimeSettings.IOSBuildResourceDirectory";

		// Token: 0x0400AD71 RID: 44401
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AD72 RID: 44402
		internal static int __PropertyOffset_Path;
	}
}
