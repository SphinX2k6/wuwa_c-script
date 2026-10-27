using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002652 RID: 9810
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PrefabSystem.NestedPrefabInstanceChain")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNestedPrefabInstanceChain : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602475C RID: 149340 RVA: 0x0035F830 File Offset: 0x0035DA30
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNestedPrefabInstanceChain._ScriptStructPtr != 0) ? FNestedPrefabInstanceChain._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PrefabSystem.NestedPrefabInstanceChain", ref FNestedPrefabInstanceChain._ScriptStructPtr);
		}

		// Token: 0x17008C8D RID: 35981
		// (get) Token: 0x0602475D RID: 149341 RVA: 0x0035F854 File Offset: 0x0035DA54
		// (set) Token: 0x0602475E RID: 149342 RVA: 0x0035F864 File Offset: 0x0035DA64
		public unsafe int FileID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNestedPrefabInstanceChain.__PropertyOffset_FileID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNestedPrefabInstanceChain.__PropertyOffset_FileID) = value;
			}
		}

		// Token: 0x17008C8E RID: 35982
		// (get) Token: 0x0602475F RID: 149343 RVA: 0x0035F878 File Offset: 0x0035DA78
		// (set) Token: 0x06024760 RID: 149344 RVA: 0x0035F8BB File Offset: 0x0035DABB
		public TArray<int> FileIDChain
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._FileIDChain) == null)
				{
					result = (this._FileIDChain = new TArray<int>(base.NativePtr + (IntPtr)FNestedPrefabInstanceChain.__PropertyOffset_FileIDChain, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FileIDChain.CopyAssign(value);
			}
		}

		// Token: 0x06024761 RID: 149345 RVA: 0x0035F8C9 File Offset: 0x0035DAC9
		public FNestedPrefabInstanceChain()
		{
		}

		// Token: 0x06024762 RID: 149346 RVA: 0x0035F8D1 File Offset: 0x0035DAD1
		public FNestedPrefabInstanceChain(int FileID, TArray<int> FileIDChain)
		{
			this.FileID = FileID;
			this.FileIDChain = FileIDChain;
		}

		// Token: 0x06024763 RID: 149347 RVA: 0x0035F8E7 File Offset: 0x0035DAE7
		protected override IntPtr GetUStructPtr()
		{
			return FNestedPrefabInstanceChain.StaticStruct();
		}

		// Token: 0x06024764 RID: 149348 RVA: 0x0035F8F3 File Offset: 0x0035DAF3
		[NullableContext(2)]
		public FNestedPrefabInstanceChain(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024765 RID: 149349 RVA: 0x0035F8FD File Offset: 0x0035DAFD
		public FNestedPrefabInstanceChain(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024766 RID: 149350 RVA: 0x0035F908 File Offset: 0x0035DB08
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNestedPrefabInstanceChain(Pointer, false, true);
		}

		// Token: 0x06024767 RID: 149351 RVA: 0x0035F912 File Offset: 0x0035DB12
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNestedPrefabInstanceChain(Pointer, MemoryOwner);
		}

		// Token: 0x04013964 RID: 80228
		public const string __ObjectPath = "/Script/PrefabSystem.NestedPrefabInstanceChain";

		// Token: 0x04013965 RID: 80229
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013966 RID: 80230
		internal static int __PropertyOffset_FileID;

		// Token: 0x04013967 RID: 80231
		internal static int __PropertyOffset_FileIDChain;

		// Token: 0x04013968 RID: 80232
		[Nullable(2)]
		private TArray<int> _FileIDChain;
	}
}
