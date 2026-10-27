using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C45 RID: 3141
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.IndexedCurve")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FIndexedCurve : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009F69 RID: 40809 RVA: 0x000E28F8 File Offset: 0x000E0AF8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIndexedCurve._ScriptStructPtr != 0) ? FIndexedCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.IndexedCurve", ref FIndexedCurve._ScriptStructPtr);
		}

		// Token: 0x17002606 RID: 9734
		// (get) Token: 0x06009F6A RID: 40810 RVA: 0x000E291C File Offset: 0x000E0B1C
		// (set) Token: 0x06009F6B RID: 40811 RVA: 0x000E295F File Offset: 0x000E0B5F
		public FKeyHandleMap KeyHandlesToIndices
		{
			get
			{
				base.FastCheckIsValid();
				FKeyHandleMap result;
				if ((result = this._KeyHandlesToIndices) == null)
				{
					result = (this._KeyHandlesToIndices = new FKeyHandleMap(base.NativePtr + (IntPtr)FIndexedCurve.__PropertyOffset_KeyHandlesToIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKeyHandleMap.StaticStruct(), base.NativePtr + (IntPtr)FIndexedCurve.__PropertyOffset_KeyHandlesToIndices, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06009F6C RID: 40812 RVA: 0x000E2980 File Offset: 0x000E0B80
		public FIndexedCurve()
		{
		}

		// Token: 0x06009F6D RID: 40813 RVA: 0x000E2988 File Offset: 0x000E0B88
		public FIndexedCurve(FKeyHandleMap KeyHandlesToIndices)
		{
			this.KeyHandlesToIndices = KeyHandlesToIndices;
		}

		// Token: 0x06009F6E RID: 40814 RVA: 0x000E2997 File Offset: 0x000E0B97
		protected override IntPtr GetUStructPtr()
		{
			return FIndexedCurve.StaticStruct();
		}

		// Token: 0x06009F6F RID: 40815 RVA: 0x000E29A3 File Offset: 0x000E0BA3
		[NullableContext(2)]
		public FIndexedCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009F70 RID: 40816 RVA: 0x000E29AD File Offset: 0x000E0BAD
		public FIndexedCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009F71 RID: 40817 RVA: 0x000E29B8 File Offset: 0x000E0BB8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIndexedCurve(Pointer, false, true);
		}

		// Token: 0x06009F72 RID: 40818 RVA: 0x000E29C2 File Offset: 0x000E0BC2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIndexedCurve(Pointer, MemoryOwner);
		}

		// Token: 0x040057BD RID: 22461
		public const string __ObjectPath = "/Script/Engine.IndexedCurve";

		// Token: 0x040057BE RID: 22462
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040057BF RID: 22463
		internal static int __PropertyOffset_KeyHandlesToIndices;

		// Token: 0x040057C0 RID: 22464
		[Nullable(2)]
		private FKeyHandleMap _KeyHandlesToIndices;
	}
}
