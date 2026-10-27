using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200282D RID: 10285
	[UnrealObjectPath("/Script/SlateCore.SlateSound")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSlateSound : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026395 RID: 156565 RVA: 0x003A0440 File Offset: 0x0039E640
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSlateSound._ScriptStructPtr != 0) ? FSlateSound._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.SlateSound", ref FSlateSound._ScriptStructPtr);
		}

		// Token: 0x1700938F RID: 37775
		// (get) Token: 0x06026396 RID: 156566 RVA: 0x003A0464 File Offset: 0x0039E664
		// (set) Token: 0x06026397 RID: 156567 RVA: 0x003A0478 File Offset: 0x0039E678
		[Nullable(2)]
		public unsafe UObject ResourceObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FSlateSound.__PropertyOffset_ResourceObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSlateSound.__PropertyOffset_ResourceObject, value);
			}
		}

		// Token: 0x06026398 RID: 156568 RVA: 0x003A048D File Offset: 0x0039E68D
		public FSlateSound()
		{
		}

		// Token: 0x06026399 RID: 156569 RVA: 0x003A0495 File Offset: 0x0039E695
		[NullableContext(1)]
		public FSlateSound(UObject ResourceObject)
		{
			this.ResourceObject = ResourceObject;
		}

		// Token: 0x0602639A RID: 156570 RVA: 0x003A04A4 File Offset: 0x0039E6A4
		protected override IntPtr GetUStructPtr()
		{
			return FSlateSound.StaticStruct();
		}

		// Token: 0x0602639B RID: 156571 RVA: 0x003A04B0 File Offset: 0x0039E6B0
		[NullableContext(2)]
		public FSlateSound(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602639C RID: 156572 RVA: 0x003A04BA File Offset: 0x0039E6BA
		public FSlateSound(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602639D RID: 156573 RVA: 0x003A04C5 File Offset: 0x0039E6C5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSlateSound(Pointer, false, true);
		}

		// Token: 0x0602639E RID: 156574 RVA: 0x003A04CF File Offset: 0x0039E6CF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSlateSound(Pointer, MemoryOwner);
		}

		// Token: 0x04014EBE RID: 85694
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SlateCore.SlateSound";

		// Token: 0x04014EBF RID: 85695
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014EC0 RID: 85696
		internal static int __PropertyOffset_ResourceObject;
	}
}
