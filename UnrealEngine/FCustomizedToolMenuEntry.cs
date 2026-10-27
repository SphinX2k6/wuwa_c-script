using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002843 RID: 10307
	[UnrealObjectPath("/Script/Slate.CustomizedToolMenuEntry")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FCustomizedToolMenuEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060264D5 RID: 156885 RVA: 0x003A2EA6 File Offset: 0x003A10A6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCustomizedToolMenuEntry._ScriptStructPtr != 0) ? FCustomizedToolMenuEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Slate.CustomizedToolMenuEntry", ref FCustomizedToolMenuEntry._ScriptStructPtr);
		}

		// Token: 0x170093E5 RID: 37861
		// (get) Token: 0x060264D6 RID: 156886 RVA: 0x003A2ECA File Offset: 0x003A10CA
		// (set) Token: 0x060264D7 RID: 156887 RVA: 0x003A2EDA File Offset: 0x003A10DA
		public unsafe ECustomizedToolMenuVisibility Visibility
		{
			get
			{
				return (ECustomizedToolMenuVisibility)(*(base.NativePtr + (IntPtr)FCustomizedToolMenuEntry.__PropertyOffset_Visibility));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCustomizedToolMenuEntry.__PropertyOffset_Visibility) = (int)value;
			}
		}

		// Token: 0x060264D8 RID: 156888 RVA: 0x003A2EEB File Offset: 0x003A10EB
		public FCustomizedToolMenuEntry()
		{
		}

		// Token: 0x060264D9 RID: 156889 RVA: 0x003A2EF3 File Offset: 0x003A10F3
		public FCustomizedToolMenuEntry(ECustomizedToolMenuVisibility Visibility)
		{
			this.Visibility = Visibility;
		}

		// Token: 0x060264DA RID: 156890 RVA: 0x003A2F02 File Offset: 0x003A1102
		protected override IntPtr GetUStructPtr()
		{
			return FCustomizedToolMenuEntry.StaticStruct();
		}

		// Token: 0x060264DB RID: 156891 RVA: 0x003A2F0E File Offset: 0x003A110E
		[NullableContext(2)]
		public FCustomizedToolMenuEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060264DC RID: 156892 RVA: 0x003A2F18 File Offset: 0x003A1118
		public FCustomizedToolMenuEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060264DD RID: 156893 RVA: 0x003A2F23 File Offset: 0x003A1123
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCustomizedToolMenuEntry(Pointer, false, true);
		}

		// Token: 0x060264DE RID: 156894 RVA: 0x003A2F2D File Offset: 0x003A112D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCustomizedToolMenuEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04014F92 RID: 85906
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Slate.CustomizedToolMenuEntry";

		// Token: 0x04014F93 RID: 85907
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014F94 RID: 85908
		internal static int __PropertyOffset_Visibility;
	}
}
