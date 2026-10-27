using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200288C RID: 10380
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SMSystem.SMNodeDescription")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FSMNodeDescription : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602672C RID: 157484 RVA: 0x003A87CE File Offset: 0x003A69CE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMNodeDescription._ScriptStructPtr != 0) ? FSMNodeDescription._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMNodeDescription", ref FSMNodeDescription._ScriptStructPtr);
		}

		// Token: 0x17009437 RID: 37943
		// (get) Token: 0x0602672D RID: 157485 RVA: 0x003A87F2 File Offset: 0x003A69F2
		// (set) Token: 0x0602672E RID: 157486 RVA: 0x003A8806 File Offset: 0x003A6A06
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMNodeDescription.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMNodeDescription.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17009438 RID: 37944
		// (get) Token: 0x0602672F RID: 157487 RVA: 0x003A881C File Offset: 0x003A6A1C
		// (set) Token: 0x06026730 RID: 157488 RVA: 0x003A885F File Offset: 0x003A6A5F
		public unsafe FText Category
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Category) == null)
				{
					result = (this._Category = new FText(base.NativePtr + (IntPtr)FSMNodeDescription.__PropertyOffset_Category, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FSMNodeDescription.__PropertyOffset_Category)), value.NativePtr, 1);
			}
		}

		// Token: 0x17009439 RID: 37945
		// (get) Token: 0x06026731 RID: 157489 RVA: 0x003A887C File Offset: 0x003A6A7C
		// (set) Token: 0x06026732 RID: 157490 RVA: 0x003A88BF File Offset: 0x003A6ABF
		public unsafe FText Description
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Description) == null)
				{
					result = (this._Description = new FText(base.NativePtr + (IntPtr)FSMNodeDescription.__PropertyOffset_Description, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FSMNodeDescription.__PropertyOffset_Description)), value.NativePtr, 1);
			}
		}

		// Token: 0x06026733 RID: 157491 RVA: 0x003A88DA File Offset: 0x003A6ADA
		public FSMNodeDescription()
		{
		}

		// Token: 0x06026734 RID: 157492 RVA: 0x003A88E2 File Offset: 0x003A6AE2
		public FSMNodeDescription(FName Name, FText Category, FText Description)
		{
			this.Name = Name;
			this.Category = Category;
			this.Description = Description;
		}

		// Token: 0x06026735 RID: 157493 RVA: 0x003A88FF File Offset: 0x003A6AFF
		protected override IntPtr GetUStructPtr()
		{
			return FSMNodeDescription.StaticStruct();
		}

		// Token: 0x06026736 RID: 157494 RVA: 0x003A890B File Offset: 0x003A6B0B
		[NullableContext(2)]
		public FSMNodeDescription(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026737 RID: 157495 RVA: 0x003A8915 File Offset: 0x003A6B15
		public FSMNodeDescription(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026738 RID: 157496 RVA: 0x003A8920 File Offset: 0x003A6B20
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMNodeDescription(Pointer, false, true);
		}

		// Token: 0x06026739 RID: 157497 RVA: 0x003A892A File Offset: 0x003A6B2A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMNodeDescription(Pointer, MemoryOwner);
		}

		// Token: 0x04015198 RID: 86424
		public const string __ObjectPath = "/Script/SMSystem.SMNodeDescription";

		// Token: 0x04015199 RID: 86425
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401519A RID: 86426
		internal static int __PropertyOffset_Name;

		// Token: 0x0401519B RID: 86427
		internal static int __PropertyOffset_Category;

		// Token: 0x0401519C RID: 86428
		[Nullable(2)]
		private FText _Category;

		// Token: 0x0401519D RID: 86429
		internal static int __PropertyOffset_Description;

		// Token: 0x0401519E RID: 86430
		[Nullable(2)]
		private FText _Description;
	}
}
