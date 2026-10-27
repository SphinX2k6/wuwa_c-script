using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001517 RID: 5399
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniNiagara.PointIndexes")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPointIndexes : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013AA6 RID: 80550 RVA: 0x001CE2BB File Offset: 0x001CC4BB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPointIndexes._ScriptStructPtr != 0) ? FPointIndexes._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniNiagara.PointIndexes", ref FPointIndexes._ScriptStructPtr);
		}

		// Token: 0x17004D02 RID: 19714
		// (get) Token: 0x06013AA7 RID: 80551 RVA: 0x001CE2E0 File Offset: 0x001CC4E0
		// (set) Token: 0x06013AA8 RID: 80552 RVA: 0x001CE323 File Offset: 0x001CC523
		public TArray<int> SampleIndexes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SampleIndexes) == null)
				{
					result = (this._SampleIndexes = new TArray<int>(base.NativePtr + (IntPtr)FPointIndexes.__PropertyOffset_SampleIndexes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SampleIndexes.CopyAssign(value);
			}
		}

		// Token: 0x06013AA9 RID: 80553 RVA: 0x001CE331 File Offset: 0x001CC531
		public FPointIndexes()
		{
		}

		// Token: 0x06013AAA RID: 80554 RVA: 0x001CE339 File Offset: 0x001CC539
		public FPointIndexes(TArray<int> SampleIndexes)
		{
			this.SampleIndexes = SampleIndexes;
		}

		// Token: 0x06013AAB RID: 80555 RVA: 0x001CE348 File Offset: 0x001CC548
		protected override IntPtr GetUStructPtr()
		{
			return FPointIndexes.StaticStruct();
		}

		// Token: 0x06013AAC RID: 80556 RVA: 0x001CE354 File Offset: 0x001CC554
		[NullableContext(2)]
		public FPointIndexes(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013AAD RID: 80557 RVA: 0x001CE35E File Offset: 0x001CC55E
		public FPointIndexes(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013AAE RID: 80558 RVA: 0x001CE369 File Offset: 0x001CC569
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPointIndexes(Pointer, false, true);
		}

		// Token: 0x06013AAF RID: 80559 RVA: 0x001CE373 File Offset: 0x001CC573
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPointIndexes(Pointer, MemoryOwner);
		}

		// Token: 0x0400A9DE RID: 43486
		public const string __ObjectPath = "/Script/HoudiniNiagara.PointIndexes";

		// Token: 0x0400A9DF RID: 43487
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A9E0 RID: 43488
		internal static int __PropertyOffset_SampleIndexes;

		// Token: 0x0400A9E1 RID: 43489
		[Nullable(2)]
		private TArray<int> _SampleIndexes;
	}
}
