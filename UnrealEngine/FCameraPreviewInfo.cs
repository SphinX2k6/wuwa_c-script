using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000910 RID: 2320
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CameraPreviewInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FCameraPreviewInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007FAE RID: 32686 RVA: 0x000B706F File Offset: 0x000B526F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraPreviewInfo._ScriptStructPtr != 0) ? FCameraPreviewInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CameraPreviewInfo", ref FCameraPreviewInfo._ScriptStructPtr);
		}

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x06007FAF RID: 32687 RVA: 0x000B7093 File Offset: 0x000B5293
		// (set) Token: 0x06007FB0 RID: 32688 RVA: 0x000B70A7 File Offset: 0x000B52A7
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<APawn> PawnClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraPreviewInfo.__PropertyOffset_PawnClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FCameraPreviewInfo.__PropertyOffset_PawnClass) = value;
			}
		}

		// Token: 0x17001E07 RID: 7687
		// (get) Token: 0x06007FB1 RID: 32689 RVA: 0x000B70BC File Offset: 0x000B52BC
		// (set) Token: 0x06007FB2 RID: 32690 RVA: 0x000B70D0 File Offset: 0x000B52D0
		public unsafe UAnimSequence AnimSeq
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + FCameraPreviewInfo.__PropertyOffset_AnimSeq);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCameraPreviewInfo.__PropertyOffset_AnimSeq, value);
			}
		}

		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x06007FB3 RID: 32691 RVA: 0x000B70E5 File Offset: 0x000B52E5
		// (set) Token: 0x06007FB4 RID: 32692 RVA: 0x000B70F9 File Offset: 0x000B52F9
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraPreviewInfo.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraPreviewInfo.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17001E09 RID: 7689
		// (get) Token: 0x06007FB5 RID: 32693 RVA: 0x000B710E File Offset: 0x000B530E
		// (set) Token: 0x06007FB6 RID: 32694 RVA: 0x000B7122 File Offset: 0x000B5322
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraPreviewInfo.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraPreviewInfo.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17001E0A RID: 7690
		// (get) Token: 0x06007FB7 RID: 32695 RVA: 0x000B7137 File Offset: 0x000B5337
		// (set) Token: 0x06007FB8 RID: 32696 RVA: 0x000B714B File Offset: 0x000B534B
		public unsafe APawn PawnInst
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APawn>(base.NativePtr / (IntPtr)sizeof(void*) + FCameraPreviewInfo.__PropertyOffset_PawnInst);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCameraPreviewInfo.__PropertyOffset_PawnInst, value);
			}
		}

		// Token: 0x06007FB9 RID: 32697 RVA: 0x000B7160 File Offset: 0x000B5360
		public FCameraPreviewInfo()
		{
		}

		// Token: 0x06007FBA RID: 32698 RVA: 0x000B7168 File Offset: 0x000B5368
		[NullableContext(1)]
		public FCameraPreviewInfo([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<APawn> PawnClass, UAnimSequence AnimSeq, FVector Location, FRotator Rotation, APawn PawnInst)
		{
			this.PawnClass = PawnClass;
			this.AnimSeq = AnimSeq;
			this.Location = Location;
			this.Rotation = Rotation;
			this.PawnInst = PawnInst;
		}

		// Token: 0x06007FBB RID: 32699 RVA: 0x000B7195 File Offset: 0x000B5395
		protected override IntPtr GetUStructPtr()
		{
			return FCameraPreviewInfo.StaticStruct();
		}

		// Token: 0x06007FBC RID: 32700 RVA: 0x000B71A1 File Offset: 0x000B53A1
		public FCameraPreviewInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007FBD RID: 32701 RVA: 0x000B71AB File Offset: 0x000B53AB
		public FCameraPreviewInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007FBE RID: 32702 RVA: 0x000B71B6 File Offset: 0x000B53B6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraPreviewInfo(Pointer, false, true);
		}

		// Token: 0x06007FBF RID: 32703 RVA: 0x000B71C0 File Offset: 0x000B53C0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraPreviewInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003D37 RID: 15671
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CameraPreviewInfo";

		// Token: 0x04003D38 RID: 15672
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003D39 RID: 15673
		internal static int __PropertyOffset_PawnClass;

		// Token: 0x04003D3A RID: 15674
		internal static int __PropertyOffset_AnimSeq;

		// Token: 0x04003D3B RID: 15675
		internal static int __PropertyOffset_Location;

		// Token: 0x04003D3C RID: 15676
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04003D3D RID: 15677
		internal static int __PropertyOffset_PawnInst;
	}
}
