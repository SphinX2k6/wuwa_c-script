using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200164F RID: 5711
	[UnrealObjectPath("/Script/KuroAnim.IKTarget")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FIKTarget : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060148EC RID: 84204 RVA: 0x001E3D04 File Offset: 0x001E1F04
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIKTarget._ScriptStructPtr != 0) ? FIKTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.IKTarget", ref FIKTarget._ScriptStructPtr);
		}

		// Token: 0x170050F0 RID: 20720
		// (get) Token: 0x060148ED RID: 84205 RVA: 0x001E3D28 File Offset: 0x001E1F28
		// (set) Token: 0x060148EE RID: 84206 RVA: 0x001E3D3C File Offset: 0x001E1F3C
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIKTarget.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIKTarget.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x170050F1 RID: 20721
		// (get) Token: 0x060148EF RID: 84207 RVA: 0x001E3D51 File Offset: 0x001E1F51
		// (set) Token: 0x060148F0 RID: 84208 RVA: 0x001E3D65 File Offset: 0x001E1F65
		public unsafe FQuat Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIKTarget.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIKTarget.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x170050F2 RID: 20722
		// (get) Token: 0x060148F1 RID: 84209 RVA: 0x001E3D7A File Offset: 0x001E1F7A
		// (set) Token: 0x060148F2 RID: 84210 RVA: 0x001E3D8A File Offset: 0x001E1F8A
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIKTarget.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIKTarget.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x060148F3 RID: 84211 RVA: 0x001E3D9B File Offset: 0x001E1F9B
		public FIKTarget()
		{
		}

		// Token: 0x060148F4 RID: 84212 RVA: 0x001E3DA3 File Offset: 0x001E1FA3
		public FIKTarget(FVector Location, FQuat Rotation, float Alpha)
		{
			this.Location = Location;
			this.Rotation = Rotation;
			this.Alpha = Alpha;
		}

		// Token: 0x060148F5 RID: 84213 RVA: 0x001E3DC0 File Offset: 0x001E1FC0
		protected override IntPtr GetUStructPtr()
		{
			return FIKTarget.StaticStruct();
		}

		// Token: 0x060148F6 RID: 84214 RVA: 0x001E3DCC File Offset: 0x001E1FCC
		[NullableContext(2)]
		public FIKTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060148F7 RID: 84215 RVA: 0x001E3DD6 File Offset: 0x001E1FD6
		public FIKTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060148F8 RID: 84216 RVA: 0x001E3DE1 File Offset: 0x001E1FE1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIKTarget(Pointer, false, true);
		}

		// Token: 0x060148F9 RID: 84217 RVA: 0x001E3DEB File Offset: 0x001E1FEB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIKTarget(Pointer, MemoryOwner);
		}

		// Token: 0x0400B399 RID: 45977
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.IKTarget";

		// Token: 0x0400B39A RID: 45978
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B39B RID: 45979
		internal static int __PropertyOffset_Location;

		// Token: 0x0400B39C RID: 45980
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400B39D RID: 45981
		internal static int __PropertyOffset_Alpha;
	}
}
