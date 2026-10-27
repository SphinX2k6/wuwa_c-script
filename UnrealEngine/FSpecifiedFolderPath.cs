using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200116F RID: 4463
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SpecifiedFolderPath")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSpecifiedFolderPath : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060104F5 RID: 66805 RVA: 0x001806F2 File Offset: 0x0017E8F2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpecifiedFolderPath._ScriptStructPtr != 0) ? FSpecifiedFolderPath._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SpecifiedFolderPath", ref FSpecifiedFolderPath._ScriptStructPtr);
		}

		// Token: 0x17003FE9 RID: 16361
		// (get) Token: 0x060104F6 RID: 66806 RVA: 0x00180716 File Offset: 0x0017E916
		// (set) Token: 0x060104F7 RID: 66807 RVA: 0x0018072A File Offset: 0x0017E92A
		public unsafe string FolderPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSpecifiedFolderPath.__PropertyOffset_FolderPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSpecifiedFolderPath.__PropertyOffset_FolderPath)), value);
			}
		}

		// Token: 0x17003FEA RID: 16362
		// (get) Token: 0x060104F8 RID: 66808 RVA: 0x00180740 File Offset: 0x0017E940
		// (set) Token: 0x060104F9 RID: 66809 RVA: 0x00180783 File Offset: 0x0017E983
		public TArray<string> DataLayers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DataLayers) == null)
				{
					result = (this._DataLayers = new TArray<string>(base.NativePtr + (IntPtr)FSpecifiedFolderPath.__PropertyOffset_DataLayers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DataLayers.CopyAssign(value);
			}
		}

		// Token: 0x060104FA RID: 66810 RVA: 0x00180791 File Offset: 0x0017E991
		public FSpecifiedFolderPath()
		{
		}

		// Token: 0x060104FB RID: 66811 RVA: 0x00180799 File Offset: 0x0017E999
		public FSpecifiedFolderPath(string FolderPath, TArray<string> DataLayers)
		{
			this.FolderPath = FolderPath;
			this.DataLayers = DataLayers;
		}

		// Token: 0x060104FC RID: 66812 RVA: 0x001807AF File Offset: 0x0017E9AF
		protected override IntPtr GetUStructPtr()
		{
			return FSpecifiedFolderPath.StaticStruct();
		}

		// Token: 0x060104FD RID: 66813 RVA: 0x001807BB File Offset: 0x0017E9BB
		[NullableContext(2)]
		public FSpecifiedFolderPath(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060104FE RID: 66814 RVA: 0x001807C5 File Offset: 0x0017E9C5
		public FSpecifiedFolderPath(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060104FF RID: 66815 RVA: 0x001807D0 File Offset: 0x0017E9D0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpecifiedFolderPath(Pointer, false, true);
		}

		// Token: 0x06010500 RID: 66816 RVA: 0x001807DA File Offset: 0x0017E9DA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpecifiedFolderPath(Pointer, MemoryOwner);
		}

		// Token: 0x04008C5C RID: 35932
		public const string __ObjectPath = "/Script/Engine.SpecifiedFolderPath";

		// Token: 0x04008C5D RID: 35933
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008C5E RID: 35934
		internal static int __PropertyOffset_FolderPath;

		// Token: 0x04008C5F RID: 35935
		internal static int __PropertyOffset_DataLayers;

		// Token: 0x04008C60 RID: 35936
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DataLayers;
	}
}
