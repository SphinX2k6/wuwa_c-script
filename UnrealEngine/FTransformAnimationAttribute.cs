using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011FC RID: 4604
	[UnrealObjectPath("/Script/Engine.TransformAnimationAttribute")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FTransformAnimationAttribute : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010FA2 RID: 69538 RVA: 0x0018EAB1 File Offset: 0x0018CCB1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransformAnimationAttribute._ScriptStructPtr != 0) ? FTransformAnimationAttribute._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TransformAnimationAttribute", ref FTransformAnimationAttribute._ScriptStructPtr);
		}

		// Token: 0x1700425A RID: 16986
		// (get) Token: 0x06010FA3 RID: 69539 RVA: 0x0018EAD5 File Offset: 0x0018CCD5
		// (set) Token: 0x06010FA4 RID: 69540 RVA: 0x0018EAE9 File Offset: 0x0018CCE9
		public unsafe FTransform Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransformAnimationAttribute.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransformAnimationAttribute.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06010FA5 RID: 69541 RVA: 0x0018EAFE File Offset: 0x0018CCFE
		public FTransformAnimationAttribute()
		{
		}

		// Token: 0x06010FA6 RID: 69542 RVA: 0x0018EB06 File Offset: 0x0018CD06
		public FTransformAnimationAttribute(FTransform Value)
		{
			this.Value = Value;
		}

		// Token: 0x06010FA7 RID: 69543 RVA: 0x0018EB15 File Offset: 0x0018CD15
		protected override IntPtr GetUStructPtr()
		{
			return FTransformAnimationAttribute.StaticStruct();
		}

		// Token: 0x06010FA8 RID: 69544 RVA: 0x0018EB21 File Offset: 0x0018CD21
		[NullableContext(2)]
		public FTransformAnimationAttribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010FA9 RID: 69545 RVA: 0x0018EB2B File Offset: 0x0018CD2B
		public FTransformAnimationAttribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010FAA RID: 69546 RVA: 0x0018EB36 File Offset: 0x0018CD36
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTransformAnimationAttribute(Pointer, false, true);
		}

		// Token: 0x06010FAB RID: 69547 RVA: 0x0018EB40 File Offset: 0x0018CD40
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTransformAnimationAttribute(Pointer, MemoryOwner);
		}

		// Token: 0x04009178 RID: 37240
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TransformAnimationAttribute";

		// Token: 0x04009179 RID: 37241
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400917A RID: 37242
		internal static int __PropertyOffset_Value;
	}
}
