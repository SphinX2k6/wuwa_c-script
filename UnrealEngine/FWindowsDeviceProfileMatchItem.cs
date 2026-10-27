using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A69 RID: 10857
	[UnrealObjectPath("/Script/WindowsDeviceProfileSelector.WindowsDeviceProfileMatchItem")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FWindowsDeviceProfileMatchItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060280F3 RID: 164083 RVA: 0x003CFBAE File Offset: 0x003CDDAE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWindowsDeviceProfileMatchItem._ScriptStructPtr != 0) ? FWindowsDeviceProfileMatchItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WindowsDeviceProfileSelector.WindowsDeviceProfileMatchItem", ref FWindowsDeviceProfileMatchItem._ScriptStructPtr);
		}

		// Token: 0x170098F7 RID: 39159
		// (get) Token: 0x060280F4 RID: 164084 RVA: 0x003CFBD2 File Offset: 0x003CDDD2
		// (set) Token: 0x060280F5 RID: 164085 RVA: 0x003CFBE6 File Offset: 0x003CDDE6
		public unsafe TEnumAsByte<EDataSourceType> SourceType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWindowsDeviceProfileMatchItem.__PropertyOffset_SourceType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWindowsDeviceProfileMatchItem.__PropertyOffset_SourceType) = value;
			}
		}

		// Token: 0x170098F8 RID: 39160
		// (get) Token: 0x060280F6 RID: 164086 RVA: 0x003CFBFB File Offset: 0x003CDDFB
		// (set) Token: 0x060280F7 RID: 164087 RVA: 0x003CFC0F File Offset: 0x003CDE0F
		public unsafe TEnumAsByte<EDataCompareType> CompareType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWindowsDeviceProfileMatchItem.__PropertyOffset_CompareType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWindowsDeviceProfileMatchItem.__PropertyOffset_CompareType) = value;
			}
		}

		// Token: 0x170098F9 RID: 39161
		// (get) Token: 0x060280F8 RID: 164088 RVA: 0x003CFC24 File Offset: 0x003CDE24
		// (set) Token: 0x060280F9 RID: 164089 RVA: 0x003CFC38 File Offset: 0x003CDE38
		[Nullable(1)]
		public unsafe string MatchString
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FWindowsDeviceProfileMatchItem.__PropertyOffset_MatchString)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FWindowsDeviceProfileMatchItem.__PropertyOffset_MatchString)), value);
			}
		}

		// Token: 0x060280FA RID: 164090 RVA: 0x003CFC4D File Offset: 0x003CDE4D
		public FWindowsDeviceProfileMatchItem()
		{
		}

		// Token: 0x060280FB RID: 164091 RVA: 0x003CFC55 File Offset: 0x003CDE55
		public FWindowsDeviceProfileMatchItem(TEnumAsByte<EDataSourceType> SourceType, TEnumAsByte<EDataCompareType> CompareType, [Nullable(1)] string MatchString)
		{
			this.SourceType = SourceType;
			this.CompareType = CompareType;
			this.MatchString = MatchString;
		}

		// Token: 0x060280FC RID: 164092 RVA: 0x003CFC72 File Offset: 0x003CDE72
		protected override IntPtr GetUStructPtr()
		{
			return FWindowsDeviceProfileMatchItem.StaticStruct();
		}

		// Token: 0x060280FD RID: 164093 RVA: 0x003CFC7E File Offset: 0x003CDE7E
		[NullableContext(2)]
		public FWindowsDeviceProfileMatchItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060280FE RID: 164094 RVA: 0x003CFC88 File Offset: 0x003CDE88
		public FWindowsDeviceProfileMatchItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060280FF RID: 164095 RVA: 0x003CFC93 File Offset: 0x003CDE93
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWindowsDeviceProfileMatchItem(Pointer, false, true);
		}

		// Token: 0x06028100 RID: 164096 RVA: 0x003CFC9D File Offset: 0x003CDE9D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWindowsDeviceProfileMatchItem(Pointer, MemoryOwner);
		}

		// Token: 0x04015FAE RID: 90030
		[Nullable(1)]
		public const string __ObjectPath = "/Script/WindowsDeviceProfileSelector.WindowsDeviceProfileMatchItem";

		// Token: 0x04015FAF RID: 90031
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015FB0 RID: 90032
		internal static int __PropertyOffset_SourceType;

		// Token: 0x04015FB1 RID: 90033
		internal static int __PropertyOffset_CompareType;

		// Token: 0x04015FB2 RID: 90034
		internal static int __PropertyOffset_MatchString;
	}
}
