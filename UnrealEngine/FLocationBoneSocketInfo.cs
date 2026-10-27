using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D65 RID: 3429
	[UnrealObjectPath("/Script/Engine.LocationBoneSocketInfo")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FLocationBoneSocketInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B93B RID: 47419 RVA: 0x00107933 File Offset: 0x00105B33
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLocationBoneSocketInfo._ScriptStructPtr != 0) ? FLocationBoneSocketInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LocationBoneSocketInfo", ref FLocationBoneSocketInfo._ScriptStructPtr);
		}

		// Token: 0x17002A6F RID: 10863
		// (get) Token: 0x0600B93C RID: 47420 RVA: 0x00107957 File Offset: 0x00105B57
		// (set) Token: 0x0600B93D RID: 47421 RVA: 0x0010796B File Offset: 0x00105B6B
		public unsafe FName BoneSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLocationBoneSocketInfo.__PropertyOffset_BoneSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLocationBoneSocketInfo.__PropertyOffset_BoneSocketName) = value;
			}
		}

		// Token: 0x17002A70 RID: 10864
		// (get) Token: 0x0600B93E RID: 47422 RVA: 0x00107980 File Offset: 0x00105B80
		// (set) Token: 0x0600B93F RID: 47423 RVA: 0x00107994 File Offset: 0x00105B94
		public unsafe FVector Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLocationBoneSocketInfo.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLocationBoneSocketInfo.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x0600B940 RID: 47424 RVA: 0x001079A9 File Offset: 0x00105BA9
		public FLocationBoneSocketInfo()
		{
		}

		// Token: 0x0600B941 RID: 47425 RVA: 0x001079B1 File Offset: 0x00105BB1
		public FLocationBoneSocketInfo(FName BoneSocketName, FVector Offset)
		{
			this.BoneSocketName = BoneSocketName;
			this.Offset = Offset;
		}

		// Token: 0x0600B942 RID: 47426 RVA: 0x001079C7 File Offset: 0x00105BC7
		protected override IntPtr GetUStructPtr()
		{
			return FLocationBoneSocketInfo.StaticStruct();
		}

		// Token: 0x0600B943 RID: 47427 RVA: 0x001079D3 File Offset: 0x00105BD3
		[NullableContext(2)]
		public FLocationBoneSocketInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B944 RID: 47428 RVA: 0x001079DD File Offset: 0x00105BDD
		public FLocationBoneSocketInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B945 RID: 47429 RVA: 0x001079E8 File Offset: 0x00105BE8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLocationBoneSocketInfo(Pointer, false, true);
		}

		// Token: 0x0600B946 RID: 47430 RVA: 0x001079F2 File Offset: 0x00105BF2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLocationBoneSocketInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400610E RID: 24846
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LocationBoneSocketInfo";

		// Token: 0x0400610F RID: 24847
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006110 RID: 24848
		internal static int __PropertyOffset_BoneSocketName;

		// Token: 0x04006111 RID: 24849
		internal static int __PropertyOffset_Offset;
	}
}
