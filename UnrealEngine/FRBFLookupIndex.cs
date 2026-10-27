using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200106F RID: 4207
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Engine.RBFLookupIndex")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRBFLookupIndex : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EF5A RID: 61274 RVA: 0x00162F5B File Offset: 0x0016115B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRBFLookupIndex._ScriptStructPtr != 0) ? FRBFLookupIndex._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RBFLookupIndex", ref FRBFLookupIndex._ScriptStructPtr);
		}

		// Token: 0x170039ED RID: 14829
		// (get) Token: 0x0600EF5B RID: 61275 RVA: 0x00162F7F File Offset: 0x0016117F
		// (set) Token: 0x0600EF5C RID: 61276 RVA: 0x00162F8F File Offset: 0x0016118F
		public unsafe int IndexXY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFLookupIndex.__PropertyOffset_IndexXY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFLookupIndex.__PropertyOffset_IndexXY) = value;
			}
		}

		// Token: 0x170039EE RID: 14830
		// (get) Token: 0x0600EF5D RID: 61277 RVA: 0x00162FA0 File Offset: 0x001611A0
		// (set) Token: 0x0600EF5E RID: 61278 RVA: 0x00162FB0 File Offset: 0x001611B0
		public unsafe int IndexZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFLookupIndex.__PropertyOffset_IndexZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFLookupIndex.__PropertyOffset_IndexZ) = value;
			}
		}

		// Token: 0x0600EF5F RID: 61279 RVA: 0x00162FC1 File Offset: 0x001611C1
		public FRBFLookupIndex()
		{
		}

		// Token: 0x0600EF60 RID: 61280 RVA: 0x00162FC9 File Offset: 0x001611C9
		public FRBFLookupIndex(int IndexXY, int IndexZ, float AngleXY, float AngleZ)
		{
			this.IndexXY = IndexXY;
			this.IndexZ = IndexZ;
		}

		// Token: 0x0600EF61 RID: 61281 RVA: 0x00162FDF File Offset: 0x001611DF
		protected override IntPtr GetUStructPtr()
		{
			return FRBFLookupIndex.StaticStruct();
		}

		// Token: 0x0600EF62 RID: 61282 RVA: 0x00162FEB File Offset: 0x001611EB
		[NullableContext(2)]
		public FRBFLookupIndex(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EF63 RID: 61283 RVA: 0x00162FF5 File Offset: 0x001611F5
		public FRBFLookupIndex(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EF64 RID: 61284 RVA: 0x00163000 File Offset: 0x00161200
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRBFLookupIndex(Pointer, false, true);
		}

		// Token: 0x0600EF65 RID: 61285 RVA: 0x0016300A File Offset: 0x0016120A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRBFLookupIndex(Pointer, MemoryOwner);
		}

		// Token: 0x04008183 RID: 33155
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RBFLookupIndex";

		// Token: 0x04008184 RID: 33156
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008185 RID: 33157
		internal static int __PropertyOffset_IndexXY;

		// Token: 0x04008186 RID: 33158
		internal static int __PropertyOffset_IndexZ;
	}
}
