using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012D3 RID: 4819
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Foliage.PCGFoliageInstance")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FPCGFoliageInstance : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011AD6 RID: 72406 RVA: 0x0019F4F2 File Offset: 0x0019D6F2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPCGFoliageInstance._ScriptStructPtr != 0) ? FPCGFoliageInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Foliage.PCGFoliageInstance", ref FPCGFoliageInstance._ScriptStructPtr);
		}

		// Token: 0x1700452F RID: 17711
		// (get) Token: 0x06011AD7 RID: 72407 RVA: 0x0019F516 File Offset: 0x0019D716
		// (set) Token: 0x06011AD8 RID: 72408 RVA: 0x0019F52A File Offset: 0x0019D72A
		[Nullable(2)]
		public unsafe UFoliageType FoliageType
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFoliageType>(base.NativePtr / (IntPtr)sizeof(void*) + FPCGFoliageInstance.__PropertyOffset_FoliageType);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPCGFoliageInstance.__PropertyOffset_FoliageType, value);
			}
		}

		// Token: 0x17004530 RID: 17712
		// (get) Token: 0x06011AD9 RID: 72409 RVA: 0x0019F540 File Offset: 0x0019D740
		// (set) Token: 0x06011ADA RID: 72410 RVA: 0x0019F583 File Offset: 0x0019D783
		public TArray<int> IDs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._IDs) == null)
				{
					result = (this._IDs = new TArray<int>(base.NativePtr + (IntPtr)FPCGFoliageInstance.__PropertyOffset_IDs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IDs.CopyAssign(value);
			}
		}

		// Token: 0x06011ADB RID: 72411 RVA: 0x0019F591 File Offset: 0x0019D791
		public FPCGFoliageInstance()
		{
		}

		// Token: 0x06011ADC RID: 72412 RVA: 0x0019F599 File Offset: 0x0019D799
		public FPCGFoliageInstance(UFoliageType FoliageType, TArray<int> IDs)
		{
			this.FoliageType = FoliageType;
			this.IDs = IDs;
		}

		// Token: 0x06011ADD RID: 72413 RVA: 0x0019F5AF File Offset: 0x0019D7AF
		protected override IntPtr GetUStructPtr()
		{
			return FPCGFoliageInstance.StaticStruct();
		}

		// Token: 0x06011ADE RID: 72414 RVA: 0x0019F5BB File Offset: 0x0019D7BB
		[NullableContext(2)]
		public FPCGFoliageInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011ADF RID: 72415 RVA: 0x0019F5C5 File Offset: 0x0019D7C5
		public FPCGFoliageInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011AE0 RID: 72416 RVA: 0x0019F5D0 File Offset: 0x0019D7D0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPCGFoliageInstance(Pointer, false, true);
		}

		// Token: 0x06011AE1 RID: 72417 RVA: 0x0019F5DA File Offset: 0x0019D7DA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPCGFoliageInstance(Pointer, MemoryOwner);
		}

		// Token: 0x040097B9 RID: 38841
		public const string __ObjectPath = "/Script/Foliage.PCGFoliageInstance";

		// Token: 0x040097BA RID: 38842
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040097BB RID: 38843
		internal static int __PropertyOffset_FoliageType;

		// Token: 0x040097BC RID: 38844
		internal static int __PropertyOffset_IDs;

		// Token: 0x040097BD RID: 38845
		[Nullable(2)]
		private TArray<int> _IDs;
	}
}
