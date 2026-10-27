using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200121D RID: 4637
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Vector4Distribution")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FVector4Distribution : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011123 RID: 69923 RVA: 0x00190DC0 File Offset: 0x0018EFC0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector4Distribution._ScriptStructPtr != 0) ? FVector4Distribution._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.Vector4Distribution", ref FVector4Distribution._ScriptStructPtr);
		}

		// Token: 0x170042A9 RID: 17065
		// (get) Token: 0x06011124 RID: 69924 RVA: 0x00190DE4 File Offset: 0x0018EFE4
		// (set) Token: 0x06011125 RID: 69925 RVA: 0x00190E27 File Offset: 0x0018F027
		public FDistributionLookupTable Table
		{
			get
			{
				base.FastCheckIsValid();
				FDistributionLookupTable result;
				if ((result = this._Table) == null)
				{
					result = (this._Table = new FDistributionLookupTable(base.NativePtr + (IntPtr)FVector4Distribution.__PropertyOffset_Table, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDistributionLookupTable.StaticStruct(), base.NativePtr + (IntPtr)FVector4Distribution.__PropertyOffset_Table, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06011126 RID: 69926 RVA: 0x00190E48 File Offset: 0x0018F048
		public FVector4Distribution()
		{
		}

		// Token: 0x06011127 RID: 69927 RVA: 0x00190E50 File Offset: 0x0018F050
		public FVector4Distribution(FDistributionLookupTable Table)
		{
			this.Table = Table;
		}

		// Token: 0x06011128 RID: 69928 RVA: 0x00190E5F File Offset: 0x0018F05F
		protected override IntPtr GetUStructPtr()
		{
			return FVector4Distribution.StaticStruct();
		}

		// Token: 0x06011129 RID: 69929 RVA: 0x00190E6B File Offset: 0x0018F06B
		[NullableContext(2)]
		public FVector4Distribution(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601112A RID: 69930 RVA: 0x00190E75 File Offset: 0x0018F075
		public FVector4Distribution(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601112B RID: 69931 RVA: 0x00190E80 File Offset: 0x0018F080
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVector4Distribution(Pointer, false, true);
		}

		// Token: 0x0601112C RID: 69932 RVA: 0x00190E8A File Offset: 0x0018F08A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVector4Distribution(Pointer, MemoryOwner);
		}

		// Token: 0x0400923D RID: 37437
		public const string __ObjectPath = "/Script/Engine.Vector4Distribution";

		// Token: 0x0400923E RID: 37438
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400923F RID: 37439
		internal static int __PropertyOffset_Table;

		// Token: 0x04009240 RID: 37440
		[Nullable(2)]
		private FDistributionLookupTable _Table;
	}
}
