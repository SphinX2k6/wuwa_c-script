using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029E0 RID: 10720
	[UnrealObjectPath("/Script/UMG.TextBinding")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UTextBinding : UPropertyBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027B34 RID: 162612 RVA: 0x003C876C File Offset: 0x003C696C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextBinding._ClassPtr;
		}

		// Token: 0x06027B35 RID: 162613 RVA: 0x003C8778 File Offset: 0x003C6978
		public UTextBinding() : this(BuiltinUtils.AllocNativeUObject(UTextBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027B36 RID: 162614 RVA: 0x003C87A0 File Offset: 0x003C69A0
		[NullableContext(1)]
		public UTextBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027B37 RID: 162615 RVA: 0x003C87D3 File Offset: 0x003C69D3
		[NullableContext(1)]
		public FText GetTextValue()
		{
			return new FText(UTextBinding.__GetTextValue_Internal(base.NativePtr), null);
		}

		// Token: 0x06027B38 RID: 162616 RVA: 0x003C87E6 File Offset: 0x003C69E6
		[NullableContext(1)]
		public string GetStringValue()
		{
			return FString.ToStringAndDeleteNativePtr(UTextBinding.__GetStringValue_Internal(base.NativePtr));
		}

		// Token: 0x06027B39 RID: 162617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTextValue_Internal(IntPtr @this);

		// Token: 0x06027B3A RID: 162618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetStringValue_Internal(IntPtr @this);

		// Token: 0x06027B3B RID: 162619 RVA: 0x003C87F8 File Offset: 0x003C69F8
		static UTextBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.TextBinding");
		}

		// Token: 0x06027B3C RID: 162620 RVA: 0x003C8806 File Offset: 0x003C6A06
		protected UTextBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015BD9 RID: 89049
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.TextBinding";

		// Token: 0x04015BDA RID: 89050
		private static IntPtr _ClassPtr;

		// Token: 0x04015BDB RID: 89051
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
