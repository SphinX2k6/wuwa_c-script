using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001405 RID: 5125
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GDKPlatformEditor.GDKPackageStringResources")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FGDKPackageStringResources : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012B0B RID: 76555 RVA: 0x001B83B1 File Offset: 0x001B65B1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGDKPackageStringResources._ScriptStructPtr != 0) ? FGDKPackageStringResources._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GDKPlatformEditor.GDKPackageStringResources", ref FGDKPackageStringResources._ScriptStructPtr);
		}

		// Token: 0x1700485E RID: 18526
		// (get) Token: 0x06012B0C RID: 76556 RVA: 0x001B83D5 File Offset: 0x001B65D5
		// (set) Token: 0x06012B0D RID: 76557 RVA: 0x001B83E9 File Offset: 0x001B65E9
		public unsafe string ApplicationDisplayName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGDKPackageStringResources.__PropertyOffset_ApplicationDisplayName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGDKPackageStringResources.__PropertyOffset_ApplicationDisplayName)), value);
			}
		}

		// Token: 0x1700485F RID: 18527
		// (get) Token: 0x06012B0E RID: 76558 RVA: 0x001B83FE File Offset: 0x001B65FE
		// (set) Token: 0x06012B0F RID: 76559 RVA: 0x001B8412 File Offset: 0x001B6612
		public unsafe string ApplicationDescription
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGDKPackageStringResources.__PropertyOffset_ApplicationDescription)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGDKPackageStringResources.__PropertyOffset_ApplicationDescription)), value);
			}
		}

		// Token: 0x06012B10 RID: 76560 RVA: 0x001B8427 File Offset: 0x001B6627
		public FGDKPackageStringResources()
		{
		}

		// Token: 0x06012B11 RID: 76561 RVA: 0x001B842F File Offset: 0x001B662F
		public FGDKPackageStringResources(string ApplicationDisplayName, string ApplicationDescription)
		{
			this.ApplicationDisplayName = ApplicationDisplayName;
			this.ApplicationDescription = ApplicationDescription;
		}

		// Token: 0x06012B12 RID: 76562 RVA: 0x001B8445 File Offset: 0x001B6645
		protected override IntPtr GetUStructPtr()
		{
			return FGDKPackageStringResources.StaticStruct();
		}

		// Token: 0x06012B13 RID: 76563 RVA: 0x001B8451 File Offset: 0x001B6651
		[NullableContext(2)]
		public FGDKPackageStringResources(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012B14 RID: 76564 RVA: 0x001B845B File Offset: 0x001B665B
		public FGDKPackageStringResources(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012B15 RID: 76565 RVA: 0x001B8466 File Offset: 0x001B6666
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGDKPackageStringResources(Pointer, false, true);
		}

		// Token: 0x06012B16 RID: 76566 RVA: 0x001B8470 File Offset: 0x001B6670
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGDKPackageStringResources(Pointer, MemoryOwner);
		}

		// Token: 0x04009FDD RID: 40925
		public const string __ObjectPath = "/Script/GDKPlatformEditor.GDKPackageStringResources";

		// Token: 0x04009FDE RID: 40926
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009FDF RID: 40927
		internal static int __PropertyOffset_ApplicationDisplayName;

		// Token: 0x04009FE0 RID: 40928
		internal static int __PropertyOffset_ApplicationDescription;
	}
}
