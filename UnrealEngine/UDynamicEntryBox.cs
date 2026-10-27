using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200294F RID: 10575
	[UnrealObjectPath("/Script/UMG.DynamicEntryBox")]
	[UnrealStructLayout(976, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 976)]
	public class UDynamicEntryBox : UDynamicEntryBoxBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027286 RID: 160390 RVA: 0x003BB3DB File Offset: 0x003B95DB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDynamicEntryBox._ClassPtr;
		}

		// Token: 0x06027287 RID: 160391 RVA: 0x003BB3E8 File Offset: 0x003B95E8
		public UDynamicEntryBox() : this(BuiltinUtils.AllocNativeUObject(UDynamicEntryBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027288 RID: 160392 RVA: 0x003BB410 File Offset: 0x003B9610
		[NullableContext(1)]
		public UDynamicEntryBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDynamicEntryBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700969C RID: 38556
		// (get) Token: 0x06027289 RID: 160393 RVA: 0x003BB443 File Offset: 0x003B9643
		// (set) Token: 0x0602728A RID: 160394 RVA: 0x003BB457 File Offset: 0x003B9657
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UUserWidget> EntryWidgetClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UDynamicEntryBox.__PropertyOffset_EntryWidgetClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UDynamicEntryBox.__PropertyOffset_EntryWidgetClass) = value;
			}
		}

		// Token: 0x0602728B RID: 160395 RVA: 0x003BB46C File Offset: 0x003B966C
		public void Reset(bool bDeleteWidgets = false)
		{
			UDynamicEntryBox.__Reset_Internal(base.NativePtr, bDeleteWidgets);
		}

		// Token: 0x0602728C RID: 160396 RVA: 0x003BB47A File Offset: 0x003B967A
		[NullableContext(2)]
		public void RemoveEntry(UUserWidget EntryWidget)
		{
			UDynamicEntryBox.__RemoveEntry_Internal(base.NativePtr, (EntryWidget != null) ? EntryWidget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0602728D RID: 160397 RVA: 0x003BB497 File Offset: 0x003B9697
		[NullableContext(2)]
		public UUserWidget BP_CreateEntryOfClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UUserWidget> EntryClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUserWidget>(UDynamicEntryBox.__BP_CreateEntryOfClass_Internal(base.NativePtr, EntryClass._NativePtr));
		}

		// Token: 0x0602728E RID: 160398 RVA: 0x003BB4AF File Offset: 0x003B96AF
		[NullableContext(2)]
		public UUserWidget BP_CreateEntry()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUserWidget>(UDynamicEntryBox.__BP_CreateEntry_Internal(base.NativePtr));
		}

		// Token: 0x0602728F RID: 160399
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Reset_Internal(IntPtr @this, bool bDeleteWidgets);

		// Token: 0x06027290 RID: 160400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveEntry_Internal(IntPtr @this, IntPtr EntryWidget);

		// Token: 0x06027291 RID: 160401
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BP_CreateEntryOfClass_Internal(IntPtr @this, IntPtr EntryClass);

		// Token: 0x06027292 RID: 160402
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BP_CreateEntry_Internal(IntPtr @this);

		// Token: 0x06027293 RID: 160403 RVA: 0x003BB4C1 File Offset: 0x003B96C1
		static UDynamicEntryBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.DynamicEntryBox");
		}

		// Token: 0x06027294 RID: 160404 RVA: 0x003BB4CF File Offset: 0x003B96CF
		protected UDynamicEntryBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015803 RID: 88067
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.DynamicEntryBox";

		// Token: 0x04015804 RID: 88068
		private static IntPtr _ClassPtr;

		// Token: 0x04015805 RID: 88069
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015806 RID: 88070
		internal static int __PropertyOffset_EntryWidgetClass;
	}
}
