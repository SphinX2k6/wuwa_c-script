using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000987 RID: 2439
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CustomAttributePerBoneData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FCustomAttributePerBoneData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060089DC RID: 35292 RVA: 0x000C581A File Offset: 0x000C3A1A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCustomAttributePerBoneData._ScriptStructPtr != 0) ? FCustomAttributePerBoneData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CustomAttributePerBoneData", ref FCustomAttributePerBoneData._ScriptStructPtr);
		}

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x060089DD RID: 35293 RVA: 0x000C583E File Offset: 0x000C3A3E
		// (set) Token: 0x060089DE RID: 35294 RVA: 0x000C584E File Offset: 0x000C3A4E
		public unsafe int BoneTreeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCustomAttributePerBoneData.__PropertyOffset_BoneTreeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCustomAttributePerBoneData.__PropertyOffset_BoneTreeIndex) = value;
			}
		}

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x060089DF RID: 35295 RVA: 0x000C5860 File Offset: 0x000C3A60
		// (set) Token: 0x060089E0 RID: 35296 RVA: 0x000C58A3 File Offset: 0x000C3AA3
		public TArray<FCustomAttribute> Attributes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCustomAttribute> result;
				if ((result = this._Attributes) == null)
				{
					result = (this._Attributes = new TArray<FCustomAttribute>(base.NativePtr + (IntPtr)FCustomAttributePerBoneData.__PropertyOffset_Attributes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Attributes.CopyAssign(value);
			}
		}

		// Token: 0x060089E1 RID: 35297 RVA: 0x000C58B1 File Offset: 0x000C3AB1
		public FCustomAttributePerBoneData()
		{
		}

		// Token: 0x060089E2 RID: 35298 RVA: 0x000C58B9 File Offset: 0x000C3AB9
		public FCustomAttributePerBoneData(int BoneTreeIndex, TArray<FCustomAttribute> Attributes)
		{
			this.BoneTreeIndex = BoneTreeIndex;
			this.Attributes = Attributes;
		}

		// Token: 0x060089E3 RID: 35299 RVA: 0x000C58CF File Offset: 0x000C3ACF
		protected override IntPtr GetUStructPtr()
		{
			return FCustomAttributePerBoneData.StaticStruct();
		}

		// Token: 0x060089E4 RID: 35300 RVA: 0x000C58DB File Offset: 0x000C3ADB
		[NullableContext(2)]
		public FCustomAttributePerBoneData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060089E5 RID: 35301 RVA: 0x000C58E5 File Offset: 0x000C3AE5
		public FCustomAttributePerBoneData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060089E6 RID: 35302 RVA: 0x000C58F0 File Offset: 0x000C3AF0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCustomAttributePerBoneData(Pointer, false, true);
		}

		// Token: 0x060089E7 RID: 35303 RVA: 0x000C58FA File Offset: 0x000C3AFA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCustomAttributePerBoneData(Pointer, MemoryOwner);
		}

		// Token: 0x04004176 RID: 16758
		public const string __ObjectPath = "/Script/Engine.CustomAttributePerBoneData";

		// Token: 0x04004177 RID: 16759
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004178 RID: 16760
		internal static int __PropertyOffset_BoneTreeIndex;

		// Token: 0x04004179 RID: 16761
		internal static int __PropertyOffset_Attributes;

		// Token: 0x0400417A RID: 16762
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCustomAttribute> _Attributes;
	}
}
