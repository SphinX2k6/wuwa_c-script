using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002667 RID: 9831
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PropertyAccess.PropertyAccessIndirectionChain")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FPropertyAccessIndirectionChain : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602487B RID: 149627 RVA: 0x003614B0 File Offset: 0x0035F6B0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPropertyAccessIndirectionChain._ScriptStructPtr != 0) ? FPropertyAccessIndirectionChain._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PropertyAccess.PropertyAccessIndirectionChain", ref FPropertyAccessIndirectionChain._ScriptStructPtr);
		}

		// Token: 0x17008CCC RID: 36044
		// (get) Token: 0x0602487C RID: 149628 RVA: 0x003614D4 File Offset: 0x0035F6D4
		// (set) Token: 0x0602487D RID: 149629 RVA: 0x003614E4 File Offset: 0x0035F6E4
		public unsafe Unusable Property
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyAccessIndirectionChain.__PropertyOffset_Property);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessIndirectionChain.__PropertyOffset_Property) = value;
			}
		}

		// Token: 0x17008CCD RID: 36045
		// (get) Token: 0x0602487E RID: 149630 RVA: 0x003614F5 File Offset: 0x0035F6F5
		// (set) Token: 0x0602487F RID: 149631 RVA: 0x00361505 File Offset: 0x0035F705
		public unsafe int IndirectionStartIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyAccessIndirectionChain.__PropertyOffset_IndirectionStartIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessIndirectionChain.__PropertyOffset_IndirectionStartIndex) = value;
			}
		}

		// Token: 0x17008CCE RID: 36046
		// (get) Token: 0x06024880 RID: 149632 RVA: 0x00361516 File Offset: 0x0035F716
		// (set) Token: 0x06024881 RID: 149633 RVA: 0x00361526 File Offset: 0x0035F726
		public unsafe int IndirectionEndIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyAccessIndirectionChain.__PropertyOffset_IndirectionEndIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessIndirectionChain.__PropertyOffset_IndirectionEndIndex) = value;
			}
		}

		// Token: 0x17008CCF RID: 36047
		// (get) Token: 0x06024882 RID: 149634 RVA: 0x00361537 File Offset: 0x0035F737
		// (set) Token: 0x06024883 RID: 149635 RVA: 0x00361547 File Offset: 0x0035F747
		public unsafe int EventId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyAccessIndirectionChain.__PropertyOffset_EventId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyAccessIndirectionChain.__PropertyOffset_EventId) = value;
			}
		}

		// Token: 0x06024884 RID: 149636 RVA: 0x00361558 File Offset: 0x0035F758
		public FPropertyAccessIndirectionChain()
		{
		}

		// Token: 0x06024885 RID: 149637 RVA: 0x00361560 File Offset: 0x0035F760
		public FPropertyAccessIndirectionChain(Unusable Property, int IndirectionStartIndex, int IndirectionEndIndex, int EventId)
		{
			this.Property = Property;
			this.IndirectionStartIndex = IndirectionStartIndex;
			this.IndirectionEndIndex = IndirectionEndIndex;
			this.EventId = EventId;
		}

		// Token: 0x06024886 RID: 149638 RVA: 0x00361585 File Offset: 0x0035F785
		protected override IntPtr GetUStructPtr()
		{
			return FPropertyAccessIndirectionChain.StaticStruct();
		}

		// Token: 0x06024887 RID: 149639 RVA: 0x00361591 File Offset: 0x0035F791
		[NullableContext(2)]
		public FPropertyAccessIndirectionChain(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024888 RID: 149640 RVA: 0x0036159B File Offset: 0x0035F79B
		public FPropertyAccessIndirectionChain(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024889 RID: 149641 RVA: 0x003615A6 File Offset: 0x0035F7A6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPropertyAccessIndirectionChain(Pointer, false, true);
		}

		// Token: 0x0602488A RID: 149642 RVA: 0x003615B0 File Offset: 0x0035F7B0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPropertyAccessIndirectionChain(Pointer, MemoryOwner);
		}

		// Token: 0x04013A0A RID: 80394
		public const string __ObjectPath = "/Script/PropertyAccess.PropertyAccessIndirectionChain";

		// Token: 0x04013A0B RID: 80395
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013A0C RID: 80396
		internal static int __PropertyOffset_Property;

		// Token: 0x04013A0D RID: 80397
		internal static int __PropertyOffset_IndirectionStartIndex;

		// Token: 0x04013A0E RID: 80398
		internal static int __PropertyOffset_IndirectionEndIndex;

		// Token: 0x04013A0F RID: 80399
		internal static int __PropertyOffset_EventId;
	}
}
