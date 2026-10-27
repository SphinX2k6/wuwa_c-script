using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029F0 RID: 10736
	[UnrealObjectPath("/Script/UMG.VerticalBox")]
	[UnrealStructLayout(696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 696)]
	public class UVerticalBox : UPanelWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027D14 RID: 163092 RVA: 0x003CAC43 File Offset: 0x003C8E43
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVerticalBox._ClassPtr;
		}

		// Token: 0x06027D15 RID: 163093 RVA: 0x003CAC50 File Offset: 0x003C8E50
		public UVerticalBox() : this(BuiltinUtils.AllocNativeUObject(UVerticalBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027D16 RID: 163094 RVA: 0x003CAC78 File Offset: 0x003C8E78
		[NullableContext(1)]
		public UVerticalBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVerticalBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027D17 RID: 163095 RVA: 0x003CACAB File Offset: 0x003C8EAB
		[NullableContext(2)]
		public UVerticalBoxSlot AddChildToVerticalBox(UWidget Content)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UVerticalBoxSlot>(UVerticalBox.__AddChildToVerticalBox_Internal(base.NativePtr, (Content != null) ? Content.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06027D18 RID: 163096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddChildToVerticalBox_Internal(IntPtr @this, IntPtr Content);

		// Token: 0x06027D19 RID: 163097 RVA: 0x003CACCD File Offset: 0x003C8ECD
		static UVerticalBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.VerticalBox");
		}

		// Token: 0x06027D1A RID: 163098 RVA: 0x003CACDB File Offset: 0x003C8EDB
		protected UVerticalBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C65 RID: 89189
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.VerticalBox";

		// Token: 0x04015C66 RID: 89190
		private static IntPtr _ClassPtr;

		// Token: 0x04015C67 RID: 89191
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
