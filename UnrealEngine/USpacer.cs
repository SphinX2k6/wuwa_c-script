using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029DE RID: 10718
	[UnrealObjectPath("/Script/UMG.Spacer")]
	[UnrealStructLayout(680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 680)]
	public class USpacer : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027AC2 RID: 162498 RVA: 0x003C7EF3 File Offset: 0x003C60F3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpacer._ClassPtr;
		}

		// Token: 0x06027AC3 RID: 162499 RVA: 0x003C7F00 File Offset: 0x003C6100
		public USpacer() : this(BuiltinUtils.AllocNativeUObject(USpacer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027AC4 RID: 162500 RVA: 0x003C7F28 File Offset: 0x003C6128
		[NullableContext(1)]
		public USpacer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpacer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170097FF RID: 38911
		// (get) Token: 0x06027AC5 RID: 162501 RVA: 0x003C7F5B File Offset: 0x003C615B
		// (set) Token: 0x06027AC6 RID: 162502 RVA: 0x003C7F6F File Offset: 0x003C616F
		public unsafe FVector2D Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpacer.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpacer.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x06027AC7 RID: 162503 RVA: 0x003C7F84 File Offset: 0x003C6184
		public void SetSize(FVector2D InSize)
		{
			USpacer.__SetSize_Internal(base.NativePtr, InSize);
		}

		// Token: 0x06027AC8 RID: 162504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSize_Internal(IntPtr @this, FVector2D InSize);

		// Token: 0x06027AC9 RID: 162505 RVA: 0x003C7F92 File Offset: 0x003C6192
		static USpacer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.Spacer");
		}

		// Token: 0x06027ACA RID: 162506 RVA: 0x003C7FA0 File Offset: 0x003C61A0
		protected USpacer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015BA8 RID: 89000
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.Spacer";

		// Token: 0x04015BA9 RID: 89001
		private static IntPtr _ClassPtr;

		// Token: 0x04015BAA RID: 89002
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015BAB RID: 89003
		internal static int __PropertyOffset_Size;
	}
}
