using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000435 RID: 1077
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/BuildPatchServices.SHAHashData")]
	[UnrealStructLayout(20, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FSHAHashData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060039EF RID: 14831 RVA: 0x00057D0C File Offset: 0x00055F0C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSHAHashData._ScriptStructPtr != 0) ? FSHAHashData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/BuildPatchServices.SHAHashData", ref FSHAHashData._ScriptStructPtr);
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x060039F0 RID: 14832 RVA: 0x00057D30 File Offset: 0x00055F30
		// (set) Token: 0x060039F1 RID: 14833 RVA: 0x00057D75 File Offset: 0x00055F75
		public TFixedArray<byte> Hash
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<byte> result;
				if ((result = this._Hash) == null)
				{
					result = (this._Hash = new TFixedArray<byte>(base.NativePtr + (IntPtr)FSHAHashData.__PropertyOffset_Hash, 20, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Hash.CopyAssign(value);
			}
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x00057D83 File Offset: 0x00055F83
		public FSHAHashData()
		{
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x00057D8B File Offset: 0x00055F8B
		public FSHAHashData(TFixedArray<byte> Hash)
		{
			this.Hash = Hash;
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x00057D9A File Offset: 0x00055F9A
		protected override IntPtr GetUStructPtr()
		{
			return FSHAHashData.StaticStruct();
		}

		// Token: 0x060039F5 RID: 14837 RVA: 0x00057DA6 File Offset: 0x00055FA6
		[NullableContext(2)]
		public FSHAHashData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x00057DB0 File Offset: 0x00055FB0
		public FSHAHashData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x00057DBB File Offset: 0x00055FBB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSHAHashData(Pointer, false, true);
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x00057DC5 File Offset: 0x00055FC5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSHAHashData(Pointer, MemoryOwner);
		}

		// Token: 0x04001A68 RID: 6760
		public const string __ObjectPath = "/Script/BuildPatchServices.SHAHashData";

		// Token: 0x04001A69 RID: 6761
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001A6A RID: 6762
		internal static int __PropertyOffset_Hash;

		// Token: 0x04001A6B RID: 6763
		[Nullable(2)]
		private TFixedArray<byte> _Hash;
	}
}
