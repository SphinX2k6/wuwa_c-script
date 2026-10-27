using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000AE9 RID: 2793
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EncloseSpaceFolderCheck")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FEncloseSpaceFolderCheck : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009040 RID: 36928 RVA: 0x000CE779 File Offset: 0x000CC979
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEncloseSpaceFolderCheck._ScriptStructPtr != 0) ? FEncloseSpaceFolderCheck._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EncloseSpaceFolderCheck", ref FEncloseSpaceFolderCheck._ScriptStructPtr);
		}

		// Token: 0x1700220F RID: 8719
		// (get) Token: 0x06009041 RID: 36929 RVA: 0x000CE7A0 File Offset: 0x000CC9A0
		// (set) Token: 0x06009042 RID: 36930 RVA: 0x000CE7E3 File Offset: 0x000CC9E3
		public TArray<string> EnclosedSpace
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._EnclosedSpace) == null)
				{
					result = (this._EnclosedSpace = new TArray<string>(base.NativePtr + (IntPtr)FEncloseSpaceFolderCheck.__PropertyOffset_EnclosedSpace, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EnclosedSpace.CopyAssign(value);
			}
		}

		// Token: 0x06009043 RID: 36931 RVA: 0x000CE7F1 File Offset: 0x000CC9F1
		public FEncloseSpaceFolderCheck()
		{
		}

		// Token: 0x06009044 RID: 36932 RVA: 0x000CE7F9 File Offset: 0x000CC9F9
		public FEncloseSpaceFolderCheck(TArray<string> EnclosedSpace)
		{
			this.EnclosedSpace = EnclosedSpace;
		}

		// Token: 0x06009045 RID: 36933 RVA: 0x000CE808 File Offset: 0x000CCA08
		protected override IntPtr GetUStructPtr()
		{
			return FEncloseSpaceFolderCheck.StaticStruct();
		}

		// Token: 0x06009046 RID: 36934 RVA: 0x000CE814 File Offset: 0x000CCA14
		[NullableContext(2)]
		public FEncloseSpaceFolderCheck(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009047 RID: 36935 RVA: 0x000CE81E File Offset: 0x000CCA1E
		public FEncloseSpaceFolderCheck(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009048 RID: 36936 RVA: 0x000CE829 File Offset: 0x000CCA29
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEncloseSpaceFolderCheck(Pointer, false, true);
		}

		// Token: 0x06009049 RID: 36937 RVA: 0x000CE833 File Offset: 0x000CCA33
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEncloseSpaceFolderCheck(Pointer, MemoryOwner);
		}

		// Token: 0x04004B4E RID: 19278
		public const string __ObjectPath = "/Script/Engine.EncloseSpaceFolderCheck";

		// Token: 0x04004B4F RID: 19279
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004B50 RID: 19280
		internal static int __PropertyOffset_EnclosedSpace;

		// Token: 0x04004B51 RID: 19281
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _EnclosedSpace;
	}
}
