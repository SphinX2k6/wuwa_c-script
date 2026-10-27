using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F08 RID: 7944
	[UnrealObjectPath("/Script/KuroUtility.PropertyPair")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPropertyPair : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E26C RID: 123500 RVA: 0x002CD420 File Offset: 0x002CB620
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPropertyPair._ScriptStructPtr != 0) ? FPropertyPair._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.PropertyPair", ref FPropertyPair._ScriptStructPtr);
		}

		// Token: 0x170077CE RID: 30670
		// (get) Token: 0x0601E26D RID: 123501 RVA: 0x002CD444 File Offset: 0x002CB644
		// (set) Token: 0x0601E26E RID: 123502 RVA: 0x002CD458 File Offset: 0x002CB658
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyPair.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyPair.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x170077CF RID: 30671
		// (get) Token: 0x0601E26F RID: 123503 RVA: 0x002CD46D File Offset: 0x002CB66D
		// (set) Token: 0x0601E270 RID: 123504 RVA: 0x002CD47D File Offset: 0x002CB67D
		public unsafe bool bBelongsToActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyPair.__PropertyOffset_bBelongsToActor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyPair.__PropertyOffset_bBelongsToActor) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601E271 RID: 123505 RVA: 0x002CD48E File Offset: 0x002CB68E
		public FPropertyPair()
		{
		}

		// Token: 0x0601E272 RID: 123506 RVA: 0x002CD496 File Offset: 0x002CB696
		public FPropertyPair(FName Name, bool bBelongsToActor)
		{
			this.Name = Name;
			this.bBelongsToActor = bBelongsToActor;
		}

		// Token: 0x0601E273 RID: 123507 RVA: 0x002CD4AC File Offset: 0x002CB6AC
		protected override IntPtr GetUStructPtr()
		{
			return FPropertyPair.StaticStruct();
		}

		// Token: 0x0601E274 RID: 123508 RVA: 0x002CD4B8 File Offset: 0x002CB6B8
		[NullableContext(2)]
		public FPropertyPair(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E275 RID: 123509 RVA: 0x002CD4C2 File Offset: 0x002CB6C2
		public FPropertyPair(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E276 RID: 123510 RVA: 0x002CD4CD File Offset: 0x002CB6CD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPropertyPair(Pointer, false, true);
		}

		// Token: 0x0601E277 RID: 123511 RVA: 0x002CD4D7 File Offset: 0x002CB6D7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPropertyPair(Pointer, MemoryOwner);
		}

		// Token: 0x04010485 RID: 66693
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.PropertyPair";

		// Token: 0x04010486 RID: 66694
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010487 RID: 66695
		internal static int __PropertyOffset_Name;

		// Token: 0x04010488 RID: 66696
		internal static int __PropertyOffset_bBelongsToActor;
	}
}
