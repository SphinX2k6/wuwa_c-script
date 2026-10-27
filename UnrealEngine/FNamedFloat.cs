using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EC8 RID: 3784
	[UnrealObjectPath("/Script/Engine.NamedFloat")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNamedFloat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CCD4 RID: 52436 RVA: 0x0012A5FC File Offset: 0x001287FC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNamedFloat._ScriptStructPtr != 0) ? FNamedFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NamedFloat", ref FNamedFloat._ScriptStructPtr);
		}

		// Token: 0x17003024 RID: 12324
		// (get) Token: 0x0600CCD5 RID: 52437 RVA: 0x0012A620 File Offset: 0x00128820
		// (set) Token: 0x0600CCD6 RID: 52438 RVA: 0x0012A630 File Offset: 0x00128830
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNamedFloat.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNamedFloat.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17003025 RID: 12325
		// (get) Token: 0x0600CCD7 RID: 52439 RVA: 0x0012A641 File Offset: 0x00128841
		// (set) Token: 0x0600CCD8 RID: 52440 RVA: 0x0012A655 File Offset: 0x00128855
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNamedFloat.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNamedFloat.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x0600CCD9 RID: 52441 RVA: 0x0012A66A File Offset: 0x0012886A
		public FNamedFloat()
		{
		}

		// Token: 0x0600CCDA RID: 52442 RVA: 0x0012A672 File Offset: 0x00128872
		public FNamedFloat(float Value, FName Name)
		{
			this.Value = Value;
			this.Name = Name;
		}

		// Token: 0x0600CCDB RID: 52443 RVA: 0x0012A688 File Offset: 0x00128888
		protected override IntPtr GetUStructPtr()
		{
			return FNamedFloat.StaticStruct();
		}

		// Token: 0x0600CCDC RID: 52444 RVA: 0x0012A694 File Offset: 0x00128894
		[NullableContext(2)]
		public FNamedFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CCDD RID: 52445 RVA: 0x0012A69E File Offset: 0x0012889E
		public FNamedFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CCDE RID: 52446 RVA: 0x0012A6A9 File Offset: 0x001288A9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNamedFloat(Pointer, false, true);
		}

		// Token: 0x0600CCDF RID: 52447 RVA: 0x0012A6B3 File Offset: 0x001288B3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNamedFloat(Pointer, MemoryOwner);
		}

		// Token: 0x04006E42 RID: 28226
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NamedFloat";

		// Token: 0x04006E43 RID: 28227
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006E44 RID: 28228
		internal static int __PropertyOffset_Value;

		// Token: 0x04006E45 RID: 28229
		internal static int __PropertyOffset_Name;
	}
}
