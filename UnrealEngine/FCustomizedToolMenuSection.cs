using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002845 RID: 10309
	[UnrealObjectPath("/Script/Slate.CustomizedToolMenuSection")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FCustomizedToolMenuSection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060264E9 RID: 156905 RVA: 0x003A2FF8 File Offset: 0x003A11F8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCustomizedToolMenuSection._ScriptStructPtr != 0) ? FCustomizedToolMenuSection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Slate.CustomizedToolMenuSection", ref FCustomizedToolMenuSection._ScriptStructPtr);
		}

		// Token: 0x170093E7 RID: 37863
		// (get) Token: 0x060264EA RID: 156906 RVA: 0x003A301C File Offset: 0x003A121C
		// (set) Token: 0x060264EB RID: 156907 RVA: 0x003A302C File Offset: 0x003A122C
		public unsafe ECustomizedToolMenuVisibility Visibility
		{
			get
			{
				return (ECustomizedToolMenuVisibility)(*(base.NativePtr + (IntPtr)FCustomizedToolMenuSection.__PropertyOffset_Visibility));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCustomizedToolMenuSection.__PropertyOffset_Visibility) = (int)value;
			}
		}

		// Token: 0x060264EC RID: 156908 RVA: 0x003A303D File Offset: 0x003A123D
		public FCustomizedToolMenuSection()
		{
		}

		// Token: 0x060264ED RID: 156909 RVA: 0x003A3045 File Offset: 0x003A1245
		public FCustomizedToolMenuSection(ECustomizedToolMenuVisibility Visibility)
		{
			this.Visibility = Visibility;
		}

		// Token: 0x060264EE RID: 156910 RVA: 0x003A3054 File Offset: 0x003A1254
		protected override IntPtr GetUStructPtr()
		{
			return FCustomizedToolMenuSection.StaticStruct();
		}

		// Token: 0x060264EF RID: 156911 RVA: 0x003A3060 File Offset: 0x003A1260
		[NullableContext(2)]
		public FCustomizedToolMenuSection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060264F0 RID: 156912 RVA: 0x003A306A File Offset: 0x003A126A
		public FCustomizedToolMenuSection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060264F1 RID: 156913 RVA: 0x003A3075 File Offset: 0x003A1275
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCustomizedToolMenuSection(Pointer, false, true);
		}

		// Token: 0x060264F2 RID: 156914 RVA: 0x003A307F File Offset: 0x003A127F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCustomizedToolMenuSection(Pointer, MemoryOwner);
		}

		// Token: 0x04014F99 RID: 85913
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Slate.CustomizedToolMenuSection";

		// Token: 0x04014F9A RID: 85914
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014F9B RID: 85915
		internal static int __PropertyOffset_Visibility;
	}
}
