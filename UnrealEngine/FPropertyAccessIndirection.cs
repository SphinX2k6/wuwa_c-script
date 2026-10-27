using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002666 RID: 9830
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PropertyAccess.PropertyAccessIndirection")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FPropertyAccessIndirection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024863 RID: 149603 RVA: 0x003612F0 File Offset: 0x0035F4F0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPropertyAccessIndirection._ScriptStructPtr != 0) ? FPropertyAccessIndirection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PropertyAccess.PropertyAccessIndirection", ref FPropertyAccessIndirection._ScriptStructPtr);
		}

		// Token: 0x17008CC4 RID: 36036
		// (get) Token: 0x06024864 RID: 149604 RVA: 0x00361314 File Offset: 0x0035F514
		// (set) Token: 0x06024865 RID: 149605 RVA: 0x00361324 File Offset: 0x0035F524
		public unsafe Unusable ArrayProperty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyAccessIndirection.__PropertyOffset_ArrayProperty);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessIndirection.__PropertyOffset_ArrayProperty) = value;
			}
		}

		// Token: 0x17008CC5 RID: 36037
		// (get) Token: 0x06024866 RID: 149606 RVA: 0x00361335 File Offset: 0x0035F535
		// (set) Token: 0x06024867 RID: 149607 RVA: 0x00361349 File Offset: 0x0035F549
		[Nullable(2)]
		public unsafe UFunction Function
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFunction>(base.NativePtr / (IntPtr)sizeof(void*) + FPropertyAccessIndirection.__PropertyOffset_Function);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPropertyAccessIndirection.__PropertyOffset_Function, value);
			}
		}

		// Token: 0x17008CC6 RID: 36038
		// (get) Token: 0x06024868 RID: 149608 RVA: 0x0036135E File Offset: 0x0035F55E
		// (set) Token: 0x06024869 RID: 149609 RVA: 0x0036136E File Offset: 0x0035F56E
		public unsafe int ReturnBufferSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyAccessIndirection.__PropertyOffset_ReturnBufferSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessIndirection.__PropertyOffset_ReturnBufferSize) = value;
			}
		}

		// Token: 0x17008CC7 RID: 36039
		// (get) Token: 0x0602486A RID: 149610 RVA: 0x0036137F File Offset: 0x0035F57F
		// (set) Token: 0x0602486B RID: 149611 RVA: 0x0036138F File Offset: 0x0035F58F
		public unsafe int ReturnBufferAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyAccessIndirection.__PropertyOffset_ReturnBufferAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessIndirection.__PropertyOffset_ReturnBufferAlignment) = value;
			}
		}

		// Token: 0x17008CC8 RID: 36040
		// (get) Token: 0x0602486C RID: 149612 RVA: 0x003613A0 File Offset: 0x0035F5A0
		// (set) Token: 0x0602486D RID: 149613 RVA: 0x003613B0 File Offset: 0x0035F5B0
		public unsafe int ArrayIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyAccessIndirection.__PropertyOffset_ArrayIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessIndirection.__PropertyOffset_ArrayIndex) = value;
			}
		}

		// Token: 0x17008CC9 RID: 36041
		// (get) Token: 0x0602486E RID: 149614 RVA: 0x003613C1 File Offset: 0x0035F5C1
		// (set) Token: 0x0602486F RID: 149615 RVA: 0x003613D1 File Offset: 0x0035F5D1
		public unsafe uint Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyAccessIndirection.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessIndirection.__PropertyOffset_Offset) = (int)value;
			}
		}

		// Token: 0x17008CCA RID: 36042
		// (get) Token: 0x06024870 RID: 149616 RVA: 0x003613E2 File Offset: 0x0035F5E2
		// (set) Token: 0x06024871 RID: 149617 RVA: 0x003613F2 File Offset: 0x0035F5F2
		public unsafe EPropertyAccessObjectType ObjectType
		{
			get
			{
				return (EPropertyAccessObjectType)(*(base.NativePtr + (IntPtr)FPropertyAccessIndirection.__PropertyOffset_ObjectType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessIndirection.__PropertyOffset_ObjectType) = (byte)value;
			}
		}

		// Token: 0x17008CCB RID: 36043
		// (get) Token: 0x06024872 RID: 149618 RVA: 0x00361403 File Offset: 0x0035F603
		// (set) Token: 0x06024873 RID: 149619 RVA: 0x00361413 File Offset: 0x0035F613
		public unsafe EPropertyAccessIndirectionType Type
		{
			get
			{
				return (EPropertyAccessIndirectionType)(*(base.NativePtr + (IntPtr)FPropertyAccessIndirection.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessIndirection.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x06024874 RID: 149620 RVA: 0x00361424 File Offset: 0x0035F624
		public FPropertyAccessIndirection()
		{
		}

		// Token: 0x06024875 RID: 149621 RVA: 0x0036142C File Offset: 0x0035F62C
		public FPropertyAccessIndirection(Unusable ArrayProperty, UFunction Function, int ReturnBufferSize, int ReturnBufferAlignment, int ArrayIndex, uint Offset, EPropertyAccessObjectType ObjectType, EPropertyAccessIndirectionType Type)
		{
			this.ArrayProperty = ArrayProperty;
			this.Function = Function;
			this.ReturnBufferSize = ReturnBufferSize;
			this.ReturnBufferAlignment = ReturnBufferAlignment;
			this.ArrayIndex = ArrayIndex;
			this.Offset = Offset;
			this.ObjectType = ObjectType;
			this.Type = Type;
		}

		// Token: 0x06024876 RID: 149622 RVA: 0x0036147C File Offset: 0x0035F67C
		protected override IntPtr GetUStructPtr()
		{
			return FPropertyAccessIndirection.StaticStruct();
		}

		// Token: 0x06024877 RID: 149623 RVA: 0x00361488 File Offset: 0x0035F688
		[NullableContext(2)]
		public FPropertyAccessIndirection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024878 RID: 149624 RVA: 0x00361492 File Offset: 0x0035F692
		public FPropertyAccessIndirection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024879 RID: 149625 RVA: 0x0036149D File Offset: 0x0035F69D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPropertyAccessIndirection(Pointer, false, true);
		}

		// Token: 0x0602487A RID: 149626 RVA: 0x003614A7 File Offset: 0x0035F6A7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPropertyAccessIndirection(Pointer, MemoryOwner);
		}

		// Token: 0x04013A00 RID: 80384
		public const string __ObjectPath = "/Script/PropertyAccess.PropertyAccessIndirection";

		// Token: 0x04013A01 RID: 80385
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013A02 RID: 80386
		internal static int __PropertyOffset_ArrayProperty;

		// Token: 0x04013A03 RID: 80387
		internal static int __PropertyOffset_Function;

		// Token: 0x04013A04 RID: 80388
		internal static int __PropertyOffset_ReturnBufferSize;

		// Token: 0x04013A05 RID: 80389
		internal static int __PropertyOffset_ReturnBufferAlignment;

		// Token: 0x04013A06 RID: 80390
		internal static int __PropertyOffset_ArrayIndex;

		// Token: 0x04013A07 RID: 80391
		internal static int __PropertyOffset_Offset;

		// Token: 0x04013A08 RID: 80392
		internal static int __PropertyOffset_ObjectType;

		// Token: 0x04013A09 RID: 80393
		internal static int __PropertyOffset_Type;
	}
}
