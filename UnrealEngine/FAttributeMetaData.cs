using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200132A RID: 4906
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AttributeMetaData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FAttributeMetaData : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012112 RID: 74002 RVA: 0x001A8974 File Offset: 0x001A6B74
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAttributeMetaData._ScriptStructPtr != 0) ? FAttributeMetaData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.AttributeMetaData", ref FAttributeMetaData._ScriptStructPtr);
		}

		// Token: 0x17004667 RID: 18023
		// (get) Token: 0x06012113 RID: 74003 RVA: 0x001A8998 File Offset: 0x001A6B98
		// (set) Token: 0x06012114 RID: 74004 RVA: 0x001A89A8 File Offset: 0x001A6BA8
		public unsafe float BaseValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAttributeMetaData.__PropertyOffset_BaseValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttributeMetaData.__PropertyOffset_BaseValue) = value;
			}
		}

		// Token: 0x17004668 RID: 18024
		// (get) Token: 0x06012115 RID: 74005 RVA: 0x001A89B9 File Offset: 0x001A6BB9
		// (set) Token: 0x06012116 RID: 74006 RVA: 0x001A89C9 File Offset: 0x001A6BC9
		public unsafe float MinValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAttributeMetaData.__PropertyOffset_MinValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttributeMetaData.__PropertyOffset_MinValue) = value;
			}
		}

		// Token: 0x17004669 RID: 18025
		// (get) Token: 0x06012117 RID: 74007 RVA: 0x001A89DA File Offset: 0x001A6BDA
		// (set) Token: 0x06012118 RID: 74008 RVA: 0x001A89EA File Offset: 0x001A6BEA
		public unsafe float MaxValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAttributeMetaData.__PropertyOffset_MaxValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttributeMetaData.__PropertyOffset_MaxValue) = value;
			}
		}

		// Token: 0x1700466A RID: 18026
		// (get) Token: 0x06012119 RID: 74009 RVA: 0x001A89FB File Offset: 0x001A6BFB
		// (set) Token: 0x0601211A RID: 74010 RVA: 0x001A8A0F File Offset: 0x001A6C0F
		public unsafe string DerivedAttributeInfo
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAttributeMetaData.__PropertyOffset_DerivedAttributeInfo)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAttributeMetaData.__PropertyOffset_DerivedAttributeInfo)), value);
			}
		}

		// Token: 0x1700466B RID: 18027
		// (get) Token: 0x0601211B RID: 74011 RVA: 0x001A8A24 File Offset: 0x001A6C24
		// (set) Token: 0x0601211C RID: 74012 RVA: 0x001A8A34 File Offset: 0x001A6C34
		public unsafe bool bCanStack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAttributeMetaData.__PropertyOffset_bCanStack) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttributeMetaData.__PropertyOffset_bCanStack) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601211D RID: 74013 RVA: 0x001A8A45 File Offset: 0x001A6C45
		public FAttributeMetaData()
		{
		}

		// Token: 0x0601211E RID: 74014 RVA: 0x001A8A4D File Offset: 0x001A6C4D
		public FAttributeMetaData(float BaseValue, float MinValue, float MaxValue, string DerivedAttributeInfo, bool bCanStack)
		{
			this.BaseValue = BaseValue;
			this.MinValue = MinValue;
			this.MaxValue = MaxValue;
			this.DerivedAttributeInfo = DerivedAttributeInfo;
			this.bCanStack = bCanStack;
		}

		// Token: 0x0601211F RID: 74015 RVA: 0x001A8A7A File Offset: 0x001A6C7A
		protected override IntPtr GetUStructPtr()
		{
			return FAttributeMetaData.StaticStruct();
		}

		// Token: 0x06012120 RID: 74016 RVA: 0x001A8A86 File Offset: 0x001A6C86
		[NullableContext(2)]
		public FAttributeMetaData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012121 RID: 74017 RVA: 0x001A8A90 File Offset: 0x001A6C90
		public FAttributeMetaData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012122 RID: 74018 RVA: 0x001A8A9B File Offset: 0x001A6C9B
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAttributeMetaData(Pointer, false, true);
		}

		// Token: 0x06012123 RID: 74019 RVA: 0x001A8AA5 File Offset: 0x001A6CA5
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAttributeMetaData(Pointer, MemoryOwner);
		}

		// Token: 0x04009A5A RID: 39514
		public new const string __ObjectPath = "/Script/GameplayAbilities.AttributeMetaData";

		// Token: 0x04009A5B RID: 39515
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009A5C RID: 39516
		internal static int __PropertyOffset_BaseValue;

		// Token: 0x04009A5D RID: 39517
		internal static int __PropertyOffset_MinValue;

		// Token: 0x04009A5E RID: 39518
		internal static int __PropertyOffset_MaxValue;

		// Token: 0x04009A5F RID: 39519
		internal static int __PropertyOffset_DerivedAttributeInfo;

		// Token: 0x04009A60 RID: 39520
		internal static int __PropertyOffset_bCanStack;
	}
}
