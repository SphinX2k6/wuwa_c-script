using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BD3 RID: 3027
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.FilePath")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FFilePath : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060094D2 RID: 38098 RVA: 0x000D4614 File Offset: 0x000D2814
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFilePath._ScriptStructPtr != 0) ? FFilePath._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FilePath", ref FFilePath._ScriptStructPtr);
		}

		// Token: 0x1700239F RID: 9119
		// (get) Token: 0x060094D3 RID: 38099 RVA: 0x000D4638 File Offset: 0x000D2838
		// (set) Token: 0x060094D4 RID: 38100 RVA: 0x000D464C File Offset: 0x000D284C
		public unsafe string FilePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FFilePath.__PropertyOffset_FilePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FFilePath.__PropertyOffset_FilePath)), value);
			}
		}

		// Token: 0x060094D5 RID: 38101 RVA: 0x000D4661 File Offset: 0x000D2861
		public FFilePath()
		{
		}

		// Token: 0x060094D6 RID: 38102 RVA: 0x000D4669 File Offset: 0x000D2869
		public FFilePath(string FilePath)
		{
			this.FilePath = FilePath;
		}

		// Token: 0x060094D7 RID: 38103 RVA: 0x000D4678 File Offset: 0x000D2878
		protected override IntPtr GetUStructPtr()
		{
			return FFilePath.StaticStruct();
		}

		// Token: 0x060094D8 RID: 38104 RVA: 0x000D4684 File Offset: 0x000D2884
		[NullableContext(2)]
		public FFilePath(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060094D9 RID: 38105 RVA: 0x000D468E File Offset: 0x000D288E
		public FFilePath(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060094DA RID: 38106 RVA: 0x000D4699 File Offset: 0x000D2899
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFilePath(Pointer, false, true);
		}

		// Token: 0x060094DB RID: 38107 RVA: 0x000D46A3 File Offset: 0x000D28A3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFilePath(Pointer, MemoryOwner);
		}

		// Token: 0x04005391 RID: 21393
		public const string __ObjectPath = "/Script/Engine.FilePath";

		// Token: 0x04005392 RID: 21394
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005393 RID: 21395
		internal static int __PropertyOffset_FilePath;
	}
}
