using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001213 RID: 4627
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Engine.UniqueNetIdRepl")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FUniqueNetIdRepl : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011092 RID: 69778 RVA: 0x0018FFC9 File Offset: 0x0018E1C9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FUniqueNetIdRepl._ScriptStructPtr != 0) ? FUniqueNetIdRepl._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.UniqueNetIdRepl", ref FUniqueNetIdRepl._ScriptStructPtr);
		}

		// Token: 0x17004280 RID: 17024
		// (get) Token: 0x06011093 RID: 69779 RVA: 0x0018FFF0 File Offset: 0x0018E1F0
		// (set) Token: 0x06011094 RID: 69780 RVA: 0x00190033 File Offset: 0x0018E233
		public TArray<byte> ReplicationBytes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._ReplicationBytes) == null)
				{
					result = (this._ReplicationBytes = new TArray<byte>(base.NativePtr + (IntPtr)FUniqueNetIdRepl.__PropertyOffset_ReplicationBytes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ReplicationBytes.CopyAssign(value);
			}
		}

		// Token: 0x06011095 RID: 69781 RVA: 0x00190041 File Offset: 0x0018E241
		public FUniqueNetIdRepl()
		{
		}

		// Token: 0x06011096 RID: 69782 RVA: 0x00190049 File Offset: 0x0018E249
		public FUniqueNetIdRepl(TArray<byte> ReplicationBytes)
		{
			this.ReplicationBytes = ReplicationBytes;
		}

		// Token: 0x06011097 RID: 69783 RVA: 0x00190058 File Offset: 0x0018E258
		protected override IntPtr GetUStructPtr()
		{
			return FUniqueNetIdRepl.StaticStruct();
		}

		// Token: 0x06011098 RID: 69784 RVA: 0x00190064 File Offset: 0x0018E264
		[NullableContext(2)]
		public FUniqueNetIdRepl(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011099 RID: 69785 RVA: 0x0019006E File Offset: 0x0018E26E
		public FUniqueNetIdRepl(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601109A RID: 69786 RVA: 0x00190079 File Offset: 0x0018E279
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FUniqueNetIdRepl(Pointer, false, true);
		}

		// Token: 0x0601109B RID: 69787 RVA: 0x00190083 File Offset: 0x0018E283
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FUniqueNetIdRepl(Pointer, MemoryOwner);
		}

		// Token: 0x040091E6 RID: 37350
		public const string __ObjectPath = "/Script/Engine.UniqueNetIdRepl";

		// Token: 0x040091E7 RID: 37351
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040091E8 RID: 37352
		internal static int __PropertyOffset_ReplicationBytes;

		// Token: 0x040091E9 RID: 37353
		[Nullable(2)]
		private TArray<byte> _ReplicationBytes;
	}
}
