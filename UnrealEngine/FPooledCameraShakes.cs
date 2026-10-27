using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200101A RID: 4122
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PooledCameraShakes")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPooledCameraShakes : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E180 RID: 57728 RVA: 0x0014B722 File Offset: 0x00149922
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPooledCameraShakes._ScriptStructPtr != 0) ? FPooledCameraShakes._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PooledCameraShakes", ref FPooledCameraShakes._ScriptStructPtr);
		}

		// Token: 0x170034FB RID: 13563
		// (get) Token: 0x0600E181 RID: 57729 RVA: 0x0014B748 File Offset: 0x00149948
		// (set) Token: 0x0600E182 RID: 57730 RVA: 0x0014B78B File Offset: 0x0014998B
		public TArray<UCameraShakeBase> PooledShakes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UCameraShakeBase> result;
				if ((result = this._PooledShakes) == null)
				{
					result = (this._PooledShakes = new TArray<UCameraShakeBase>(base.NativePtr + (IntPtr)FPooledCameraShakes.__PropertyOffset_PooledShakes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PooledShakes.CopyAssign(value);
			}
		}

		// Token: 0x0600E183 RID: 57731 RVA: 0x0014B799 File Offset: 0x00149999
		public FPooledCameraShakes()
		{
		}

		// Token: 0x0600E184 RID: 57732 RVA: 0x0014B7A1 File Offset: 0x001499A1
		public FPooledCameraShakes(TArray<UCameraShakeBase> PooledShakes)
		{
			this.PooledShakes = PooledShakes;
		}

		// Token: 0x0600E185 RID: 57733 RVA: 0x0014B7B0 File Offset: 0x001499B0
		protected override IntPtr GetUStructPtr()
		{
			return FPooledCameraShakes.StaticStruct();
		}

		// Token: 0x0600E186 RID: 57734 RVA: 0x0014B7BC File Offset: 0x001499BC
		[NullableContext(2)]
		public FPooledCameraShakes(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E187 RID: 57735 RVA: 0x0014B7C6 File Offset: 0x001499C6
		public FPooledCameraShakes(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E188 RID: 57736 RVA: 0x0014B7D1 File Offset: 0x001499D1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPooledCameraShakes(Pointer, false, true);
		}

		// Token: 0x0600E189 RID: 57737 RVA: 0x0014B7DB File Offset: 0x001499DB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPooledCameraShakes(Pointer, MemoryOwner);
		}

		// Token: 0x04007916 RID: 30998
		public const string __ObjectPath = "/Script/Engine.PooledCameraShakes";

		// Token: 0x04007917 RID: 30999
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007918 RID: 31000
		internal static int __PropertyOffset_PooledShakes;

		// Token: 0x04007919 RID: 31001
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UCameraShakeBase> _PooledShakes;
	}
}
