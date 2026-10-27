using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002BF RID: 703
	[UnrealObjectPath("/Script/AnimationCore.EulerTransform")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FEulerTransform : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600270A RID: 9994 RVA: 0x0003AA48 File Offset: 0x00038C48
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEulerTransform._ScriptStructPtr != 0) ? FEulerTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.EulerTransform", ref FEulerTransform._ScriptStructPtr);
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x0003AA6C File Offset: 0x00038C6C
		// (set) Token: 0x0600270C RID: 9996 RVA: 0x0003AA80 File Offset: 0x00038C80
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEulerTransform.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEulerTransform.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x0003AA95 File Offset: 0x00038C95
		// (set) Token: 0x0600270E RID: 9998 RVA: 0x0003AAA9 File Offset: 0x00038CA9
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEulerTransform.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEulerTransform.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x0003AABE File Offset: 0x00038CBE
		// (set) Token: 0x06002710 RID: 10000 RVA: 0x0003AAD2 File Offset: 0x00038CD2
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEulerTransform.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEulerTransform.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x0003AAE7 File Offset: 0x00038CE7
		public FEulerTransform()
		{
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x0003AAEF File Offset: 0x00038CEF
		public FEulerTransform(FVector Location, FRotator Rotation, FVector Scale)
		{
			this.Location = Location;
			this.Rotation = Rotation;
			this.Scale = Scale;
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x0003AB0C File Offset: 0x00038D0C
		protected override IntPtr GetUStructPtr()
		{
			return FEulerTransform.StaticStruct();
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x0003AB18 File Offset: 0x00038D18
		[NullableContext(2)]
		public FEulerTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x0003AB22 File Offset: 0x00038D22
		public FEulerTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x0003AB2D File Offset: 0x00038D2D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEulerTransform(Pointer, false, true);
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x0003AB37 File Offset: 0x00038D37
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEulerTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04000F63 RID: 3939
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimationCore.EulerTransform";

		// Token: 0x04000F64 RID: 3940
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F65 RID: 3941
		internal static int __PropertyOffset_Location;

		// Token: 0x04000F66 RID: 3942
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04000F67 RID: 3943
		internal static int __PropertyOffset_Scale;
	}
}
