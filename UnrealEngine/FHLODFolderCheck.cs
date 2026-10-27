using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C2D RID: 3117
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HLODFolderCheck")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FHLODFolderCheck : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009E14 RID: 40468 RVA: 0x000E0B02 File Offset: 0x000DED02
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHLODFolderCheck._ScriptStructPtr != 0) ? FHLODFolderCheck._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HLODFolderCheck", ref FHLODFolderCheck._ScriptStructPtr);
		}

		// Token: 0x170025C9 RID: 9673
		// (get) Token: 0x06009E15 RID: 40469 RVA: 0x000E0B28 File Offset: 0x000DED28
		// (set) Token: 0x06009E16 RID: 40470 RVA: 0x000E0B6B File Offset: 0x000DED6B
		public TArray<string> HLODFolder
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._HLODFolder) == null)
				{
					result = (this._HLODFolder = new TArray<string>(base.NativePtr + (IntPtr)FHLODFolderCheck.__PropertyOffset_HLODFolder, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HLODFolder.CopyAssign(value);
			}
		}

		// Token: 0x170025CA RID: 9674
		// (get) Token: 0x06009E17 RID: 40471 RVA: 0x000E0B7C File Offset: 0x000DED7C
		// (set) Token: 0x06009E18 RID: 40472 RVA: 0x000E0BBF File Offset: 0x000DEDBF
		public TArray<string> Vegetatition
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Vegetatition) == null)
				{
					result = (this._Vegetatition = new TArray<string>(base.NativePtr + (IntPtr)FHLODFolderCheck.__PropertyOffset_Vegetatition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Vegetatition.CopyAssign(value);
			}
		}

		// Token: 0x170025CB RID: 9675
		// (get) Token: 0x06009E19 RID: 40473 RVA: 0x000E0BCD File Offset: 0x000DEDCD
		// (set) Token: 0x06009E1A RID: 40474 RVA: 0x000E0BE1 File Offset: 0x000DEDE1
		public unsafe string HLODPattern
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHLODFolderCheck.__PropertyOffset_HLODPattern)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHLODFolderCheck.__PropertyOffset_HLODPattern)), value);
			}
		}

		// Token: 0x170025CC RID: 9676
		// (get) Token: 0x06009E1B RID: 40475 RVA: 0x000E0BF6 File Offset: 0x000DEDF6
		// (set) Token: 0x06009E1C RID: 40476 RVA: 0x000E0C0A File Offset: 0x000DEE0A
		public unsafe string CustomHLODPattern
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHLODFolderCheck.__PropertyOffset_CustomHLODPattern)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHLODFolderCheck.__PropertyOffset_CustomHLODPattern)), value);
			}
		}

		// Token: 0x170025CD RID: 9677
		// (get) Token: 0x06009E1D RID: 40477 RVA: 0x000E0C20 File Offset: 0x000DEE20
		// (set) Token: 0x06009E1E RID: 40478 RVA: 0x000E0C63 File Offset: 0x000DEE63
		public TMap<string, int> MapHLODLock
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, int> result;
				if ((result = this._MapHLODLock) == null)
				{
					result = (this._MapHLODLock = new TMap<string, int>(base.NativePtr + (IntPtr)FHLODFolderCheck.__PropertyOffset_MapHLODLock, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MapHLODLock.CopyAssign(value);
			}
		}

		// Token: 0x06009E1F RID: 40479 RVA: 0x000E0C71 File Offset: 0x000DEE71
		public FHLODFolderCheck()
		{
		}

		// Token: 0x06009E20 RID: 40480 RVA: 0x000E0C79 File Offset: 0x000DEE79
		public FHLODFolderCheck(TArray<string> HLODFolder, TArray<string> Vegetatition, string HLODPattern, string CustomHLODPattern, TMap<string, int> MapHLODLock)
		{
			this.HLODFolder = HLODFolder;
			this.Vegetatition = Vegetatition;
			this.HLODPattern = HLODPattern;
			this.CustomHLODPattern = CustomHLODPattern;
			this.MapHLODLock = MapHLODLock;
		}

		// Token: 0x06009E21 RID: 40481 RVA: 0x000E0CA6 File Offset: 0x000DEEA6
		protected override IntPtr GetUStructPtr()
		{
			return FHLODFolderCheck.StaticStruct();
		}

		// Token: 0x06009E22 RID: 40482 RVA: 0x000E0CB2 File Offset: 0x000DEEB2
		[NullableContext(2)]
		public FHLODFolderCheck(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009E23 RID: 40483 RVA: 0x000E0CBC File Offset: 0x000DEEBC
		public FHLODFolderCheck(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009E24 RID: 40484 RVA: 0x000E0CC7 File Offset: 0x000DEEC7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHLODFolderCheck(Pointer, false, true);
		}

		// Token: 0x06009E25 RID: 40485 RVA: 0x000E0CD1 File Offset: 0x000DEED1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHLODFolderCheck(Pointer, MemoryOwner);
		}

		// Token: 0x04005728 RID: 22312
		public const string __ObjectPath = "/Script/Engine.HLODFolderCheck";

		// Token: 0x04005729 RID: 22313
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400572A RID: 22314
		internal static int __PropertyOffset_HLODFolder;

		// Token: 0x0400572B RID: 22315
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _HLODFolder;

		// Token: 0x0400572C RID: 22316
		internal static int __PropertyOffset_Vegetatition;

		// Token: 0x0400572D RID: 22317
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Vegetatition;

		// Token: 0x0400572E RID: 22318
		internal static int __PropertyOffset_HLODPattern;

		// Token: 0x0400572F RID: 22319
		internal static int __PropertyOffset_CustomHLODPattern;

		// Token: 0x04005730 RID: 22320
		internal static int __PropertyOffset_MapHLODLock;

		// Token: 0x04005731 RID: 22321
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _MapHLODLock;
	}
}
