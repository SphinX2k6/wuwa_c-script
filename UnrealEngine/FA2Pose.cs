using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007A1 RID: 1953
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.A2Pose")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FA2Pose : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060065D3 RID: 26067 RVA: 0x0009201B File Offset: 0x0009021B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FA2Pose._ScriptStructPtr != 0) ? FA2Pose._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.A2Pose", ref FA2Pose._ScriptStructPtr);
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x060065D4 RID: 26068 RVA: 0x00092040 File Offset: 0x00090240
		// (set) Token: 0x060065D5 RID: 26069 RVA: 0x00092083 File Offset: 0x00090283
		public TArray<FTransform> Bones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._Bones) == null)
				{
					result = (this._Bones = new TArray<FTransform>(base.NativePtr + (IntPtr)FA2Pose.__PropertyOffset_Bones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Bones.CopyAssign(value);
			}
		}

		// Token: 0x060065D6 RID: 26070 RVA: 0x00092091 File Offset: 0x00090291
		public FA2Pose()
		{
		}

		// Token: 0x060065D7 RID: 26071 RVA: 0x00092099 File Offset: 0x00090299
		public FA2Pose(TArray<FTransform> Bones)
		{
			this.Bones = Bones;
		}

		// Token: 0x060065D8 RID: 26072 RVA: 0x000920A8 File Offset: 0x000902A8
		protected override IntPtr GetUStructPtr()
		{
			return FA2Pose.StaticStruct();
		}

		// Token: 0x060065D9 RID: 26073 RVA: 0x000920B4 File Offset: 0x000902B4
		[NullableContext(2)]
		public FA2Pose(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060065DA RID: 26074 RVA: 0x000920BE File Offset: 0x000902BE
		public FA2Pose(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060065DB RID: 26075 RVA: 0x000920C9 File Offset: 0x000902C9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FA2Pose(Pointer, false, true);
		}

		// Token: 0x060065DC RID: 26076 RVA: 0x000920D3 File Offset: 0x000902D3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FA2Pose(Pointer, MemoryOwner);
		}

		// Token: 0x04003171 RID: 12657
		public const string __ObjectPath = "/Script/Engine.A2Pose";

		// Token: 0x04003172 RID: 12658
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003173 RID: 12659
		internal static int __PropertyOffset_Bones;

		// Token: 0x04003174 RID: 12660
		[Nullable(2)]
		private TArray<FTransform> _Bones;
	}
}
